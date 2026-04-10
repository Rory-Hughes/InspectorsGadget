using InspectorsGadget.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorsGadget.helpers
{
    // Requirement: Static class as helper / utility
    public static class InspectionManager
    {
        // Requirement: Data Structure - List<T> collection
        public static List<InspectionItem> Items { get; } = new List<InspectionItem>();

        /// <summary>
        /// Name of the inspector signing this report.
        /// Set by StartupForm on New Report, empty for loaded reports.
        /// </summary>
        public static string InspectorName { get; set; } = string.Empty;

        // public method to add items to the list
        public static void AddItem(InspectionItem item) => Items.Add(item);

        // public method to get total repair cost of all items, using LINQ aggregate to sum up the repair costs
        public static decimal GetTotalRepairCost()
        {
            //Requirement: Operator overloading usage via LINQ aggregate
            return Items.Aggregate(0m, (sum, item) => sum + item.RepairCost);
        }

        // public method to get average risk score of all items, using LINQ average to calculate the average risk level
        public static double GetPropertyRiskScore()
        {
            // Handle case where there are no items to avoid division by zero
            if (Items.Count == 0) return 0;
            return Items.Average(i => i.RiskLevel);
        }

        // public method to get all critical items, using LINQ where to filter items based on their IsCritical property
        public static List<InspectionItem> GetCriticalItems()
        {
            return Items.Where(i => i.IsCritical).ToList();
        }

        // Requirement: IComparable usage - sort items by risk level
        public static List<InspectionItem> GetSortedByRisk()
        {
            var sorted = new List<InspectionItem>(Items);
            sorted.Sort();
            return sorted;
        }

        // Requirement: Exception Handling for file I/O
        public static void SaveToFile(string filePath)
        {
            try
            {
                var lines = Items.Select(i => i switch
                {
                    ElectricalItem e => $"Electrical,{e.ItemName},{e.RepairCost},{e.RiskLevel},{e.Notes},{e.AmpRating},{e.HasGrounding}",
                    StructuralItem s => $"Structural,{s.ItemName},{s.RepairCost},{s.RiskLevel},{s.Notes},{s.HasVisibleCracks},{s.HasWaterDamage}",
                    ApplianceItem a => $"Appliance,{a.ItemName},{a.RepairCost},{a.RiskLevel},{a.Notes},{a.AgeInYears},{a.IsOperational}",
                    CriticalItem c => $"Critical,{c.Source.ItemName},{c.RepairCost},{c.RiskLevel},{c.Notes},{c.FlaggedBy},{c.FlaggedDate:yyyy-MM-dd}",
                    _ => throw new InvalidOperationException($"Unknown type: {i.GetType().Name}")
                });
                File.WriteAllLines(filePath, lines);
            }
            catch (IOException ex) { throw new Exception($"Failed to save: {ex.Message}"); }
        }

        public static void LoadFromFile(string filePath)
        {
            try
            {
                Items.Clear();
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var p = line.Split(',');
                    InspectionItem item = p[0] switch
                    {
                        "Electrical" => new ElectricalItem(p[1], decimal.Parse(p[2]), int.Parse(p[5]), bool.Parse(p[6])),
                        "Structural" => new StructuralItem(p[1], decimal.Parse(p[2]), bool.Parse(p[5]), bool.Parse(p[6])),
                        "Appliance" => new ApplianceItem(p[1], decimal.Parse(p[2]), int.Parse(p[5]), bool.Parse(p[6])),
                        _ => throw new InvalidDataException($"Unknown item type: {p[0]}")
                    };
                    if (!string.IsNullOrWhiteSpace(p[4])) item.AddNote(p[4]);
                    Items.Add(item);
                }
            }
            catch (IOException ex) { throw new Exception($"Failed to load: {ex.Message}"); }
        }

        public static void RemoveItem(InspectionItem item) => Items.Remove(item);

        public static void ResetFile(string filePath)
        {
            Items.Clear();
            try
            {
                var lines = Items.Select(i => i switch
                {
                    ElectricalItem e => $"Electrical,{e.ItemName},{e.RepairCost},{e.RiskLevel},{e.Notes},{e.AmpRating},{e.HasGrounding}",
                    StructuralItem s => $"Structural,{s.ItemName},{s.RepairCost},{s.RiskLevel},{s.Notes},{s.HasVisibleCracks},{s.HasWaterDamage}",
                    ApplianceItem a => $"Appliance,{a.ItemName},{a.RepairCost},{a.RiskLevel},{a.Notes},{a.AgeInYears},{a.IsOperational}",
                    CriticalItem c => $"Critical,{c.Source.ItemName},{c.RepairCost},{c.RiskLevel},{c.Notes},{c.FlaggedBy},{c.FlaggedDate:yyyy-MM-dd}",
                    _ => throw new InvalidOperationException($"Unknown type: {i.GetType().Name}")
                });
                File.WriteAllLines(filePath, lines);
            }
            catch (IOException ex) { throw new Exception($"Failed to save: {ex.Message}"); }
        }
    }
}