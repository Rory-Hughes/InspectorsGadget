using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InspectorsGadget.helpers;
using InspectorsGadget.models;
using InspectorsGadget.forms;

namespace InspectorsGadget
{
    public partial class AddItemForm : Form
    {

        private readonly string _currentFilePath;

        public AddItemForm(string filePath)
        {
            InitializeComponent();
            _currentFilePath = filePath;
            ShowPanel();
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPanel();
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
                    break;
                case "Electrical":
                    panElectrical.Visible = true;
                    panStructural.Visible = false;
                    panAppliance.Visible = false;
                    break;
                case "Structural":
                    panElectrical.Visible = false;
                    panStructural.Visible = true;
                    panAppliance.Visible = false;
                    break;
                case "Appliance":
                    panElectrical.Visible = false;
                    panStructural.Visible = false;
                    panAppliance.Visible = true;
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

                InspectionItem item = null;
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
                        item = new ElectricalItem(itemName, cost, ampRating, hasGrounding);
                        break;

                    case "Structural":
                        bool hasCracks = chkHasVisibleCracks.Checked;
                        bool hasWater = chkHasWaterDamage.Checked;
                        item = new StructuralItem(itemName, cost, hasCracks, hasWater);
                        break;

                    case "Appliance":
                        if (!int.TryParse(txtAge.Text, out int age))
                        {
                            MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        bool isOperational = chkIsOperational.Checked;
                        item = new ApplianceItem(itemName, cost, age, isOperational);
                        break;
                }

                if (item != null)
                {
                    if (!string.IsNullOrWhiteSpace(txtNotes.Text))
                    {
                        item.AddNote(txtNotes.Text);
                    }

                    InspectionManager.AddItem(item);
                    InspectionManager.SaveToFile(_currentFilePath);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}