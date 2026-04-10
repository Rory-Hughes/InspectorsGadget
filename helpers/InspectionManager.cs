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
            // average risk level is calculated by taking the average of the risk levels of all items in the list, using LINQ Average method
            return Items.Average(i => i.RiskLevel);
        }

        // public method to get all critical items, using LINQ where to filter items based on their IsCritical property
        public static List<InspectionItem> GetCriticalItems()
        {
            // returns a list of all items in the Items collection that are marked as critical, using LINQ Where method to filter the items based on their IsCritical property
            return Items.Where(i => i.IsCritical).ToList();
        }

        // Requirement: IComparable usage - sort items by risk level
        public static List<InspectionItem> GetSortedByRisk()
        {
            // creates a new list of InspectionItem objects called sorted, initialized with the items from the Items collection.
            var sorted = new List<InspectionItem>(Items);
            // It then sorts this list using the Sort method, which relies on the implementation of the IComparable interface in the InspectionItem class to determine the sorting order based on risk level.
            sorted.Sort();
            // Finally, it returns the sorted list.
            return sorted;
        }

        // Requirement: Exception Handling for file I/O
        public static void SaveToFile(string filePath)
        {
            // The method attempts to save the current list of inspection items to a file specified by the filePath parameter. It uses a try-catch block to handle potential IOExceptions that may occur during file writing operations.
            try
            {
                // It constructs a list of strings called lines, where each string represents an inspection item in a comma-separated format.
                // The method uses a switch expression to determine the type of each item and formats the string accordingly.
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

        // The LoadFromFile method attempts to read inspection items from a file specified by the filePath parameter. It also uses a try-catch block to handle potential IOExceptions that may occur during file reading operations.
        public static void LoadFromFile(string filePath)
        {
            try
            {
                // The method reads all lines from the specified file and processes each line to create corresponding InspectionItem objects.
                // It uses a switch expression to determine the type of item based on the first value in the comma-separated line and initializes the properties accordingly.
                Items.Clear();
                foreach (var line in File.ReadAllLines(filePath))
                {
                    // It splits each line into parts using the comma as a delimiter and then uses a switch expression to create the appropriate type of InspectionItem based on the first part of the line,
                    // which indicates the item type (e.g., "Electrical", "Structural", "Appliance").
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
        
        public static void RemoveItem(InspectionItem item) => Items.Remove(item); // Utility method to remove items from the list

        // The ResetFile method clears the current list of inspection items and attempts to save an empty list to the specified file path. It also uses a try-catch block to handle potential IOExceptions that may occur during file writing operations.
        public static void ResetFile(string filePath)
        {
            // The method first clears the current list of inspection items by calling Items.Clear(), ensuring that all existing items are removed from the collection.
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
            catch (IOException ex)
            {
                throw new Exception($"Failed to save: {ex.Message}");
            }
        }
    }
}
