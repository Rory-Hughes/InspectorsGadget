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

namespace InspectorsGadget
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
            PopulateDynamicFields();
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDynamicFields();
        }

        private void PopulateDynamicFields()
        {
            panDynamicFields.Controls.Clear();
            string type = cboItemType.SelectedItem?.ToString() ?? "Electrical";

            int yPos = 10;

            switch (type)
            {
                case "Electrical":
                    // Amp Rating
                    Label ampLabel = new Label();
                    ampLabel.Text = "Amp Rating:";
                    ampLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    ampLabel.Location = new Point(10, yPos);
                    ampLabel.AutoSize = true;
                    panDynamicFields.Controls.Add(ampLabel);

                    TextBox ampTextBox = new TextBox();
                    ampTextBox.Location = new Point(10, yPos + 25);
                    ampTextBox.Width = 400;
                    ampTextBox.Name = "AmpRating";
                    panDynamicFields.Controls.Add(ampTextBox);

                    yPos += 70;

                    // Grounding checkbox
                    CheckBox groundingCheckBox = new CheckBox();
                    groundingCheckBox.Text = "Has Grounding?";
                    groundingCheckBox.Location = new Point(10, yPos);
                    groundingCheckBox.AutoSize = true;
                    groundingCheckBox.Name = "HasGrounding";
                    panDynamicFields.Controls.Add(groundingCheckBox);
                    break;

                case "Structural":
                    // Visible Cracks checkbox
                    CheckBox cracksCheckBox = new CheckBox();
                    cracksCheckBox.Text = "Has Visible Cracks?";
                    cracksCheckBox.Location = new Point(10, yPos);
                    cracksCheckBox.AutoSize = true;
                    cracksCheckBox.Name = "HasVisibleCracks";
                    panDynamicFields.Controls.Add(cracksCheckBox);

                    yPos += 50;

                    // Water Damage checkbox
                    CheckBox waterCheckBox = new CheckBox();
                    waterCheckBox.Text = "Has Water Damage?";
                    waterCheckBox.Location = new Point(10, yPos);
                    waterCheckBox.AutoSize = true;
                    waterCheckBox.Name = "HasWaterDamage";
                    panDynamicFields.Controls.Add(waterCheckBox);
                    break;

                case "Appliance":
                    // Age in years
                    Label ageLabel = new Label();
                    ageLabel.Text = "Age (Years):";
                    ageLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    ageLabel.Location = new Point(10, yPos);
                    ageLabel.AutoSize = true;
                    panDynamicFields.Controls.Add(ageLabel);

                    TextBox ageTextBox = new TextBox();
                    ageTextBox.Location = new Point(10, yPos + 25);
                    ageTextBox.Width = 400;
                    ageTextBox.Name = "AgeInYears";
                    panDynamicFields.Controls.Add(ageTextBox);

                    yPos += 70;

                    // Operational checkbox
                    CheckBox operationalCheckBox = new CheckBox();
                    operationalCheckBox.Text = "Is Operational?";
                    operationalCheckBox.Location = new Point(10, yPos);
                    operationalCheckBox.AutoSize = true;
                    operationalCheckBox.Checked = true;
                    operationalCheckBox.Name = "IsOperational";
                    panDynamicFields.Controls.Add(operationalCheckBox);
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
                string type = cboItemType.SelectedItem?.ToString() ?? "Electrical";

                switch (type)
                {
                    case "Electrical":
                        if (!int.TryParse(GetDynamicFieldValue("AmpRating"), out int ampRating))
                        {
                            MessageBox.Show("Please enter a valid amp rating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        bool hasGrounding = GetDynamicCheckBoxValue("HasGrounding");
                        item = new ElectricalItem(itemName, cost, ampRating, hasGrounding);
                        break;

                    case "Structural":
                        bool hasCracks = GetDynamicCheckBoxValue("HasVisibleCracks");
                        bool hasWater = GetDynamicCheckBoxValue("HasWaterDamage");
                        item = new StructuralItem(itemName, cost, hasCracks, hasWater);
                        break;

                    case "Appliance":
                        if (!int.TryParse(GetDynamicFieldValue("AgeInYears"), out int age))
                        {
                            MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        bool isOperational = GetDynamicCheckBoxValue("IsOperational");
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
                    InspectionManager.SaveToFile("inspections.csv");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetDynamicFieldValue(string fieldName)
        {
            var control = panDynamicFields.Controls[fieldName];
            return control is TextBox tb ? tb.Text : string.Empty;
        }

        private bool GetDynamicCheckBoxValue(string fieldName)
        {
            var control = panDynamicFields.Controls[fieldName];
            return control is CheckBox cb && cb.Checked;
        }
    }
}