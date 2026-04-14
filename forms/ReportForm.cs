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
                InspectionManager.LoadFromFile("inspections.csv");

                StringBuilder report = new StringBuilder();
                report.AppendLine("═══════════════════════════════════════════════════════");
                report.AppendLine("         PROPERTY INSPECTION REPORT");
                report.AppendLine("═══════════════════════════════════════════════════════");
                report.AppendLine($"Generated: { DateTime.Now:yyyy - MM - dd HH: mm: ss}");
                report.AppendLine($"Total Items Inspected: {InspectionManager.Items.Count}");
                report.AppendLine($"Total Repair Cost: ${InspectionManager.GetTotalRepairCost():F2}");
                report.AppendLine($"Average Risk Score: {InspectionManager.GetPropertyRiskScore():F1}/10");
                report.AppendLine($"Critical Issues: {InspectionManager.GetCriticalItems().Count}");
                report.AppendLine("───────────────────────────────────────────────────────");
                report.AppendLine("DETAILED ITEMS");
                report.AppendLine("───────────────────────────────────────────────────────");

                foreach (var item in InspectionManager.GetSortedByRisk().OrderByDescending(i => i.RiskLevel))
                {
                    report.AppendLine(item.GenerateSummary());
                    if (!string.IsNullOrWhiteSpace(item.Notes))
                    {
                        report.AppendLine($"  Notes: {item.Notes}");
                    }
                    report.AppendLine();
                }

                var criticalItems = InspectionManager.GetCriticalItems();
                if (criticalItems.Count > 0)
                {
                    report.AppendLine("───────────────────────────────────────────────────────");
                    report.AppendLine("⚠️ CRITICAL ISSUES - IMMEDIATE ATTENTION REQUIRED");
                    report.AppendLine("───────────────────────────────────────────────────────");

                    foreach (var item in criticalItems)
                    {
                        report.AppendLine($"❌ {item.ItemName} ({item.GetType().Name})");
                        report.AppendLine($"   Risk Level: {item.RiskLevel}/10");
                        report.AppendLine($"   Estimated Cost: ${item.RepairCost:F2}");
                        report.AppendLine();
                    }
                }

                report.AppendLine("═══════════════════════════════════════════════════════");
                report.AppendLine("Report prepared by Inspector's Gadget");
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
                $"Report successfully sent to client! Email contains { InspectionManager.Items.Count} inspection items.",
                "Report Sent",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}

