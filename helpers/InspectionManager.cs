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
        // Source inspection items only — CriticalItems are tracked separately so
        // repair costs and counts are never double-counted.
        public static List<InspectionItem> Items { get; } = new List<InspectionItem>();

        // Separate list for items explicitly flagged via FlagCritical().
        public static List<CriticalItem> CriticalItems { get; } = new List<CriticalItem>();


        /// <summary>
        /// Name of the inspector signing this report.
        /// Set by StartupForm on New Report,
        /// </summary>
        public static string InspectorName { get; set; }

        private static string _currentFilePath;

        public static string CurrentFilePath
        {
            get => _currentFilePath;
            set => _currentFilePath = value;
        }
        // ── Item management ───────────────────────────────────────────────────

        public static void AddItem(InspectionItem item) => Items.Add(item);
        public static void RemoveItem(InspectionItem item) => Items.Remove(item);

        public static void AddCriticalItem(CriticalItem item) => CriticalItems.Add(item);
        public static void RemoveCriticalItem(CriticalItem item) => CriticalItems.Remove(item);

        // ── Metrics (source items only — no double-counting) ─────────────────

        // Requirement: Operator overloading usage via LINQ aggregate
        public static decimal GetTotalRepairCost()
            => Items.Aggregate(0m, (sum, item) => sum + item.RepairCost);

        public static double GetPropertyRiskScore()
        {
            if (Items.Count == 0) return 0;
            return Items.Average(i => i.RiskLevel);
        }

        // Returns the separate CriticalItems list — not a filter over Items.
        public static List<CriticalItem> GetCriticalItems() => CriticalItems.ToList();

        // Requirement: IComparable usage - sort source items by risk level
        public static List<InspectionItem> GetSortedByRisk()
        {
            var sorted = new List<InspectionItem>(Items);
            sorted.Sort();
            return sorted;
        }

        // ── File I/O ──────────────────────────────────────────────────────────

        // Requirement: Exception Handling for file I/O
        public static void SaveToFile(string filePath)
        {
            try
            {
                // Write source items first so they exist when Critical rows are loaded.
                // CriticalItem rows use 8 fields: type, sourceName, cost, risk, notes,
                // flaggedBy, flaggedDate, inspectorName.
                var lines = Items.Select(i => i switch
                {
                    ElectricalItem e => $"Electrical,{e.ItemName},{e.RepairCost},{e.RiskLevel},{e.Notes},{e.AmpRating},{e.HasGrounding},{e.InspectedBy}",
                    StructuralItem s => $"Structural,{s.ItemName},{s.RepairCost},{s.RiskLevel},{s.Notes},{s.HasVisibleCracks},{s.HasWaterDamage},{s.InspectedBy}",
                    ApplianceItem a => $"Appliance,{a.ItemName},{a.RepairCost},{a.RiskLevel},{a.Notes},{a.AgeInYears},{a.IsOperational},{a.InspectedBy}",
                    _ => throw new InvalidOperationException($"Unknown type: {i.GetType().Name}")
                })
                .Concat(CriticalItems.Select(c =>
                    $"Critical,{c.ItemName},{c.RepairCost},{c.RiskLevel},{c.Notes},{c.FlaggedBy},{c.FlaggedDate:yyyy-MM-dd},{InspectorName ?? ""}"));

                File.WriteAllLines(filePath, lines);
            }
            catch (IOException ex) { throw new Exception($"Failed to save: {ex.Message}"); }
        }

        public static void LoadFromFile(string filePath)
        {
            // New report — file not created yet; start with empty lists.
            if (!File.Exists(filePath))
            {
                Items.Clear();
                CriticalItems.Clear();
                return;
            }

            try
            {
                Items.Clear();
                CriticalItems.Clear();

                var allLines = File.ReadAllLines(filePath);

                // ── First pass: load all source items ────────────────────────
                foreach (var line in allLines)
                {
                    var p = line.Split(',');
                    if (p.Length < 8 || p[0] == "Critical") continue;
                    if (p[7] != null && InspectorName == null) InspectorName = p[7];

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

                // ── Second pass: rehydrate CriticalItems from saved rows ──────
                // Source items are all loaded now so look-up by name is safe.
                CriticalItems.Clear();
                foreach (var line in allLines)
                {
                    var p = line.Split(',');
                    if (p.Length < 8 || p[0] != "Critical") continue;

                    var source = Items.FirstOrDefault(i => i.ItemName == p[1]);
                    if (source == null) continue; // orphaned row — skip

                    var flaggedDate = DateTime.TryParse(p[6], out var dt) ? dt : DateTime.Now;
                    CriticalItems.Add(new CriticalItem(source, p[5], flaggedDate));
                }
            }
            catch (IOException ex) { throw new Exception($"Failed to load: {ex.Message}"); }
        }
    }
}


/*
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
        public static List<CriticalItem> GetCriticalItems()
        {
            return Items.OfType<CriticalItem>().ToList();
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
                    ElectricalItem e => $"Electrical,{e.ItemName},{e.RepairCost},{e.RiskLevel},{e.Notes},{e.AmpRating},{e.HasGrounding},{e.InspectedBy}",
                    StructuralItem s => $"Structural,{s.ItemName},{s.RepairCost},{s.RiskLevel},{s.Notes},{s.HasVisibleCracks},{s.HasWaterDamage},{s.InspectedBy}",
                    ApplianceItem a => $"Appliance,{a.ItemName},{a.RepairCost},{a.RiskLevel},{a.Notes},{a.AgeInYears},{a.IsOperational},{a.InspectedBy}",
                    CriticalItem c => $"Critical,{c.Source.ItemName},{c.RepairCost},{c.RiskLevel},{c.Notes},{c.FlaggedBy},{c.FlaggedDate:yyyy-MM-dd}",
                    _ => throw new InvalidOperationException($"Unknown type: {i.GetType().Name}")
                });
                File.WriteAllLines(filePath, lines);
            }
            catch (IOException ex) { throw new Exception($"Failed to save: {ex.Message}"); }
        }

        public static void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Items.Clear();
                return;
            }
            try
            {
                Items.Clear();
                foreach (var line in File.ReadAllLines(filePath))
                    {
                        var p = line.Split(',');
                        if (p.Length < 8) continue; // Skip invalid lines
                        if (p[7] != null && InspectorName == null) InspectorName = p[7]; // Set inspector name from file if available
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

    }
}
*/