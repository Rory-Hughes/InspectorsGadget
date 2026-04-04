using InspectorsGadget.helpers;
using InspectorsGadget.models;

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
                UpdateMetricLabel("Total Repair Cost", $"${totalCost:F2}");
                UpdateMetricLabel("Avg Risk Score", $"{avgRisk:F1} / 10");
                UpdateMetricLabel("Items Inspected", itemCount.ToString());
                UpdateMetricLabel("Critical Issues", criticalCount.ToString());

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

        private void UpdateMetricLabel(string metricName, string value)
        {
            string labelName = $"Value_{metricName.Replace(" ", "")}";
            var label = metricsPanel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == labelName);
            if (label != null)
            {
                label.Text = value;
            }
        }

        private void DashboardBtn_Click(object sender, EventArgs e) { }

        private void AddInspectionBtn_Click(object sender, EventArgs e)
        {
            // TODO: Open AddItemForm dialog
            MessageBox.Show("Add Inspection form not yet implemented", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ViewReportBtn_Click(object sender, EventArgs e)
        {
            // TODO: Open ReportForm dialog
            MessageBox.Show("Report form not yet implemented", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
