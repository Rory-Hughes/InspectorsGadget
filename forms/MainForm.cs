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

        private void DashboardBtn_Click(object sender, EventArgs e) { }

        private void AddInspectionBtn_Click(object sender, EventArgs e)
        {
            var addForm = new AddItemForm();
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                RefreshDashboard();
            }
        }

        private void ViewReportBtn_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportForm();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            // TODO: Open SettingsForm dialog
            MessageBox.Show("Settings form not yet implemented", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshBtn_Click(object sender, EventArgs e) => RefreshDashboard();

        private void ExportBtn_Click(object sender, EventArgs e)
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

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            InspectionManager.ResetFile("inspections.csv");
            RefreshDashboard();
        }
    }
}
