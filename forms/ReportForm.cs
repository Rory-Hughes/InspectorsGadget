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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InspectorsGadget
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            GenerateReport();
        }

        private void GenerateReport()
        {
            try
            {
                InspectionManager.LoadFromFile(InspectionManager.CurrentFilePath);

                // ── Header metrics ────────────────────────────────────────────
                // Items.Count is source items only — CriticalItems are tracked
                // separately, so costs and counts are never doubled.
                int itemCount = InspectionManager.Items.Count;
                decimal totalCost = InspectionManager.GetTotalRepairCost();
                double avgRisk = InspectionManager.GetPropertyRiskScore();
                var criticalItems = InspectionManager.GetCriticalItems();

                StringBuilder report = new StringBuilder();
                report.AppendLine("═══════════════════════════════════════════════════════");
                report.AppendLine("         PROPERTY INSPECTION REPORT");
                report.AppendLine("═══════════════════════════════════════════════════════");
                report.AppendLine($"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                report.AppendLine($"Total Items Inspected: {itemCount}");
                report.AppendLine($"Total Repair Cost: ${totalCost:F2}");
                report.AppendLine($"Average Risk Score: {avgRisk:F1}/10");
                report.AppendLine($"Critical Issues: {criticalItems.Count}");
                report.AppendLine("───────────────────────────────────────────────────────");

                // ── Detailed items ────────────────────────────────────────────
                // Iterates only source items (Items list) — no CriticalItem
                // wrappers appear here, so each inspection item has exactly one
                // listing and repair costs are not double-counted.
                report.AppendLine("DETAILED ITEMS");
                report.AppendLine("───────────────────────────────────────────────────────");

                foreach (var item in InspectionManager.GetSortedByRisk())
                {
                    var properties = item.GenerateSummary().Split('|');
                    for (int i = 0; i < properties.Length; i++)
                    {
                            report.AppendLine($"{properties[i]}");
                    }
                    if (!string.IsNullOrWhiteSpace(item.Notes))
                        report.AppendLine($" Notes: {item.Notes}");
                    report.AppendLine("   ────────────────────────────────   ");
                }

                // ── Critical issues ───────────────────────────────────────────
                // Comes from the separate CriticalItems list — layout unchanged.
                if (criticalItems.Count > 0)
                {
                    report.AppendLine("───────────────────────────────────────────────────────");
                    report.AppendLine("⚠️ CRITICAL ISSUES - IMMEDIATE ATTENTION REQUIRED");
                    report.AppendLine("───────────────────────────────────────────────────────");

                    foreach (var item in criticalItems)
                    {
                        report.AppendLine($"❌ {item.ItemName} ({item.Source.GetType().Name})");
                        report.AppendLine($"   Risk Level: {item.RiskLevel}/10");
                        report.AppendLine($"   Estimated Cost: ${item.RepairCost:F2}");
                        report.AppendLine($"   Flagged By: {item.FlaggedBy} on {item.FlaggedDate:yyyy-MM-dd}");
                        report.AppendLine("   ────────────────────────────────   ");
                    }
                }

                report.AppendLine("═══════════════════════════════════════════════════════");
                report.AppendLine($"Report Completed By {InspectionManager.InspectorName}");
                report.AppendLine("═══════════════════════════════════════════════════════");

                txtReport.Text = report.ToString();
            }
            catch (Exception ex)
            {
                txtReport.Text = $"Error generating report: {ex.Message}";
            }
        }

        private void SendReportBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Report successfully sent to client! Email contains {InspectionManager.Items.Count} inspection items.",
                "Report Sent",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
