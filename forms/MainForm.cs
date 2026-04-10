using InspectorsGadget.helpers;
using InspectorsGadget.models;
using System;

namespace InspectorsGadget
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RefreshDashboard();
        }

        private void RefreshDashboard()
        {
            try
            {
                // Load data from file
                InspectionManager.LoadFromFile("inspections.csv");

                // Calculate metrics
                decimal totalCost = InspectionManager.GetTotalRepairCost();
                double avgRisk = InspectionManager.GetPropertyRiskScore();
                int itemCount = InspectionManager.Items.Count;
                int criticalCount = InspectionManager.GetCriticalItems().Count;

                // Update metric labels
                lblTotalRepairCost.Text = $"${totalCost:F2}";
                lblAvgRiskScore.Text = $"{avgRisk:F1} / 10";
                lblItemsInspected.Text = itemCount.ToString();
                lblCriticalIssues.Text = criticalCount.ToString();

                // Populate grid
                itemGrid.Rows.Clear();
                foreach (var item in InspectionManager.GetSortedByRisk())
                {
                    itemGrid.Rows.Add(
                        item.ItemName,
                        item.GetType().Name.Replace("Item", ""),
                        $"{item.RiskLevel}/10",
                        $"${item.RepairCost:F2}"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // doesnt do anything yet but we want to have it there for when we implement the dashboard view with charts and graphs and stuff, so we can just switch to that view when the button is clicked
        // but right now all the other forms are just popup dialogs that you can open from the dashboard, so we want to keep it simple for now and just have the dashboard be the main view with the grid and metrics,
        // and then we can add more features to it later on when we have more time
        private void BtnDashboard_Click(object sender, EventArgs e) { }

        private void BtnAddInspection_Click(object sender, EventArgs e)
        {
            var addForm = new AddItemForm();
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                RefreshDashboard();
            }
        }

        private void BtnViewReport_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportForm();
            reportForm.ShowDialog(this);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            // TODO: Open SettingsForm dialog
            MessageBox.Show("Settings form not yet implemented", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLoadFile_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                InspectionManager.SaveToFile("inspections.csv");
                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the grid
            if (itemGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Column 0 holds ItemName - matches how rows are added in RefreshDashboard
            string selectedName = itemGrid.SelectedRows[0].Cells[0].Value?.ToString();

            // Find the actual object in the InspectionManager.Items list that matches the selected name
            var itemToRemove = InspectionManager.Items.FirstOrDefault(i => i.ItemName == selectedName);
            if (itemToRemove == null)
            {
                MessageBox.Show("Selected item not found in the data list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show($"Are you sure you want to delete '{selectedName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                InspectionManager.RemoveItem(itemToRemove);
                InspectionManager.SaveToFile("inspections.csv");
                RefreshDashboard();
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {

        }
    }
}
