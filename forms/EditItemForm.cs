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

        public EditItemForm(InspectionItem item)
        {
            InitializeComponent();
            _originalItem = item;
            LoadItemData();
        }

        // Populates all form fields from the item being edited.
        private void LoadItemData()
        {
            itemNameTextBox.Text = _originalItem.ItemName;
            repairCostTextBox.Text = _originalItem.RepairCost.ToString("F2");
            notesTextBox.Text = _originalItem.Notes;

            // Select the matching type and lock it — we replace the object on
            // save anyway, but the UI shouldn't suggest the type is changeable.
            string typeName = _originalItem.GetType().Name.Replace("Item", "");
            int idx = typeComboBox.Items.IndexOf(typeName);
            typeComboBox.SelectedIndex = idx >= 0 ? idx : 0;
            typeComboBox.Enabled = false;

            PopulateDynamicFields(_originalItem);
        }

        // Rebuilds the type-specific controls, pre-filling values when an item is supplied.
        private void PopulateDynamicFields(InspectionItem item = null)
        {
            dynamicFieldsPanel.Controls.Clear();
            string type = typeComboBox.SelectedItem?.ToString() ?? "Electrical";
            int yPos = 10;

            switch (type)
            {
                case "Electrical":
                    var elec = item as ElectricalItem;

                    dynamicFieldsPanel.Controls.Add(new Label
                    {
                        Text = "Amp Rating:",
                        Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                        Location = new Point(10, yPos),
                        AutoSize = true
                    });

                    dynamicFieldsPanel.Controls.Add(new TextBox
                    {
                        Location = new Point(10, yPos + 25),
                        Width = 400,
                        Name = "AmpRating",
                        Text = elec?.AmpRating.ToString() ?? string.Empty
                    });

                    yPos += 70;
                    dynamicFieldsPanel.Controls.Add(new CheckBox
                    {
                        Text = "Has Grounding?",
                        Location = new Point(10, yPos),
                        AutoSize = true,
                        Name = "HasGrounding",
                        Checked = elec?.HasGrounding ?? false
                    });
                    break;

                case "Structural":
                    var struc = item as StructuralItem;

                    dynamicFieldsPanel.Controls.Add(new CheckBox
                    {
                        Text = "Has Visible Cracks?",
                        Location = new Point(10, yPos),
                        AutoSize = true,
                        Name = "HasVisibleCracks",
                        Checked = struc?.HasVisibleCracks ?? false
                    });

                    yPos += 50;
                    dynamicFieldsPanel.Controls.Add(new CheckBox
                    {
                        Text = "Has Water Damage?",
                        Location = new Point(10, yPos),
                        AutoSize = true,
                        Name = "HasWaterDamage",
                        Checked = struc?.HasWaterDamage ?? false
                    });
                    break;

                case "Appliance":
                    var appl = item as ApplianceItem;

                    dynamicFieldsPanel.Controls.Add(new Label
                    {
                        Text = "Age (Years):",
                        Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                        Location = new Point(10, yPos),
                        AutoSize = true
                    });

                    dynamicFieldsPanel.Controls.Add(new TextBox
                    {
                        Location = new Point(10, yPos + 25),
                        Width = 400,
                        Name = "AgeInYears",
                        Text = appl?.AgeInYears.ToString() ?? string.Empty
                    });

                    yPos += 70;
                    dynamicFieldsPanel.Controls.Add(new CheckBox
                    {
                        Text = "Is Operational?",
                        Location = new Point(10, yPos),
                        AutoSize = true,
                        Name = "IsOperational",
                        Checked = appl?.IsOperational ?? true
                    });
                    break;
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = itemNameTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(itemName))
                {
                    MessageBox.Show("Please enter an item name.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(repairCostTextBox.Text, out decimal cost) || cost <= 0)
                {
                    MessageBox.Show("Please enter a valid repair cost (must be greater than 0).",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string type = typeComboBox.SelectedItem?.ToString() ?? "Electrical";
                InspectionItem updatedItem = null;

                switch (type)
                {
                    case "Electrical":
                        if (!int.TryParse(GetDynamicFieldValue("AmpRating"), out int ampRating))
                        {
                            MessageBox.Show("Please enter a valid amp rating.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        updatedItem = new ElectricalItem(itemName, cost, ampRating,
                            GetDynamicCheckBoxValue("HasGrounding"));
                        break;

                    case "Structural":
                        updatedItem = new StructuralItem(itemName, cost,
                            GetDynamicCheckBoxValue("HasVisibleCracks"),
                            GetDynamicCheckBoxValue("HasWaterDamage"));
                        break;

                    case "Appliance":
                        if (!int.TryParse(GetDynamicFieldValue("AgeInYears"), out int age))
                        {
                            MessageBox.Show("Please enter a valid age.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        updatedItem = new ApplianceItem(itemName, cost, age,
                            GetDynamicCheckBoxValue("IsOperational"));
                        break;
                }

                if (updatedItem != null)
                {
                    // Overwrite notes (avoid duplicating if the user didn't change them).
                    if (!string.IsNullOrWhiteSpace(notesTextBox.Text))
                        updatedItem.AddNote(notesTextBox.Text, true);

                    // Swap old object for updated one, then persist.
                    InspectionManager.RemoveItem(_originalItem);
                    InspectionManager.AddItem(updatedItem);
                    InspectionManager.SaveToFile("inspections.csv");

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

        private string GetDynamicFieldValue(string fieldName)
        {
            var control = dynamicFieldsPanel.Controls[fieldName];
            return control is TextBox tb ? tb.Text : string.Empty;
        }

        private bool GetDynamicCheckBoxValue(string fieldName)
        {
            var control = dynamicFieldsPanel.Controls[fieldName];
            return control is CheckBox cb && cb.Checked;
        }
    }
}

