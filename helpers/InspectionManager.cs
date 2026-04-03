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

        public static void AddItem(InspectionItem item) => Items.Add(item);

        public static decimal GetTotalRepairCost()
        {
            //Requirement: Operator overloading usage via LINQ aggregate
            return Items.Aggregate(0m, (sum, item) => sum + item.RepairCost);
        }

        public static double GetPropertyRiskScore()
        {
            if (Items.Count == 0) return 0;
            return Items.Average(i => i.RiskLevel);
        }

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
                var lines = Items.Select(i => i.GenerateSummary());
                System.IO.File.WriteAllLines(filePath, lines);
            }
            catch (System.IO.IOException ex)
            {
                // Surface this to the UI layer via a MessageBox
                throw new Exception($"Failed to save inspection data: {ex.Message}");
            }
        }

        public static void LoadFromFile(string filePath)
        {
            try
            {
                // TODO: Parse lines back into InspectionItem objects
                var lines = System.IO.File.ReadAllLines(filePath);
            }
            catch (System.IO.IOException ex)
            {
                throw new Exception($"Failed to load inspection data: {ex.Message}");
            }
        }
    }
}
