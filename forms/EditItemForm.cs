using InspectorsGadget.helpers;
using InspectorsGadget.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectorsGadget.forms
{
    public partial class EditItemForm : Form
    {
        private readonly InspectionItem _originalItem;
        private readonly string _currentFilePath;

        public EditItemForm(InspectionItem item, string filePath)
        {
            InitializeComponent();
            _originalItem = item;
            _currentFilePath = filePath;
            LoadItemData();
        }

        // Populates all form fields from the item being edited.
        private void LoadItemData()
        {
            txtItemName.Text = _originalItem.ItemName;
            txtRepairCost.Text = _originalItem.RepairCost.ToString("F2");
            txtNotes.Text = _originalItem.Notes;

            // Select the matching type and lock it — we replace the object on
            // save anyway, but the UI shouldn't suggest the type is changeable.
            string typeName = _originalItem.GetType().Name.Replace("Item", "");
            int idx = cboItemType.Items.IndexOf(typeName);
            cboItemType.SelectedIndex = idx >= 0 ? idx : 0;
            ShowPanel();
            cboItemType.Enabled = false;

            
        }

        private void ShowPanel()
        {
            string type = cboItemType.SelectedItem?.ToString();


            switch (type)
            {
                case null:
                    panElectrical.Visible = false;
                    panStructural.Visible = false;
                    panAppliance.Visible = false;
                    MessageBox.Show("Failed to load item type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                break;

                case "Electrical":
                    panElectrical.Visible = true;
                    panStructural.Visible = false;
                    panAppliance.Visible = false;
                    try 
                    {
                        var electrical = _originalItem as ElectricalItem;
                        if (electrical != null)
                        {
                            txtAmp.Text = electrical.AmpRating.ToString();
                            chkHasGrounding.Checked = electrical.HasGrounding;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error populating fields: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                break;

                case "Structural":
                    panElectrical.Visible = false;
                    panStructural.Visible = true;
                    panAppliance.Visible = false;
                    try
                    {
                        var structural = _originalItem as StructuralItem;
                        if (structural != null)
                        {
                            chkHasVisibleCracks.Checked = structural.HasVisibleCracks;
                            chkHasWaterDamage.Checked = structural.HasWaterDamage;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error populating fields: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Appliance":
                    panElectrical.Visible = false;
                    panStructural.Visible = false;
                    panAppliance.Visible = true;
                    try
                    {
                        var appliance = _originalItem as ApplianceItem;
                        if (appliance != null)
                        {
                            txtAge.Text = appliance.AgeInYears.ToString();
                            chkIsOperational.Checked = appliance.IsOperational;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error populating fields: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txtItemName.Text.Trim();
                if (string.IsNullOrWhiteSpace(itemName))
                {
                    MessageBox.Show("Please enter an item name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtRepairCost.Text, out decimal cost) || cost <= 0)
                {
                    MessageBox.Show("Please enter a valid repair cost (must be greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                InspectionItem updatedItem = null;
                string type = cboItemType.SelectedItem?.ToString();

                switch (type)
                {
                    case null:
                        MessageBox.Show("Please select an item type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Electrical":
                        if (!int.TryParse(txtAmp.Text, out int ampRating))
                        {
                            MessageBox.Show("Please enter a valid amp rating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        bool hasGrounding = chkHasGrounding.Checked;
                        updatedItem = new ElectricalItem(itemName, cost, ampRating, hasGrounding);
                        break;

                    case "Structural":
                        bool hasCracks = chkHasVisibleCracks.Checked;
                        bool hasWater = chkHasWaterDamage.Checked;
                        updatedItem = new StructuralItem(itemName, cost, hasCracks, hasWater);
                        break;

                    case "Appliance":
                        if (!int.TryParse(txtAge.Text, out int age))
                        {
                            MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        bool isOperational = chkIsOperational.Checked;
                        updatedItem = new ApplianceItem(itemName, cost, age, isOperational);
                        break;
                }

                if (updatedItem != null)
                {
                    // Overwrite notes (avoid duplicating if the user didn't change them).
                    if (!string.IsNullOrWhiteSpace(txtNotes.Text))
                        updatedItem.AddNote(txtNotes.Text, true);

                    // Swap old object for updated one, then persist.
                    InspectionManager.RemoveItem(_originalItem);
                    InspectionManager.AddItem(updatedItem);
                    InspectionManager.SaveToFile(_currentFilePath);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating item: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

