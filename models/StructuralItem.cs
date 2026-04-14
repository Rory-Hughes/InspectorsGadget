using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorsGadget.interfaces;

namespace InspectorsGadget.models
{
    public class StructuralItem : InspectionItem, IReportable
    {
        // Requirement: Inheritance - StructuralItem inherits from InspectionItem
        // Requirement: Additional properties specific to StructuralItem
        public bool HasVisibleCracks { get; set; }
        public bool HasWaterDamage { get; set; }

        private string CriticalMsg { get; } = "CRITICAL: Structural integrity at risk, immediate attention required!";

        // Constructor that initializes base properties and specific properties for StructuralItem
        public StructuralItem(string itemName, decimal repairCost, bool hasVisibleCracks, bool hasWaterDamage)
            : base(itemName, repairCost)
        {
            HasVisibleCracks = hasVisibleCracks;
            HasWaterDamage = hasWaterDamage;
            RiskLevel = CalculateRisk(); // Set risk level based on specific criteria
        }

        // Override the CalculateRisk method to determine risk level based on structural issues
        public override int CalculateRisk()
        {
            int risk = 1; // Base risk level
            if (HasVisibleCracks) risk += 4; // Visible cracks significantly increase risk
            if (HasWaterDamage) risk += 3; // Water damage also significantly increases risk
            if (risk >= 8) FlagCritical(base.InspectedBy); // Automatically flag as critical if risk is 8 or higher
            return Math.Clamp(risk, 1, 10); // Ensure risk level is between 1 and 10
        }

        // Override the GenerateSummary method to include specific details about the structural item
        public override string GenerateSummary()
        {
            return base.GenerateSummary() + $" | Has Visible Cracks: {HasVisibleCracks} | Has Water Damage: {HasWaterDamage}";
        }

        // Implement the GenerateReport method from the IReportable interface to provide a detailed report of the structural item
        public string GenerateReport()
        {
            return $"Structural Item Report {GenerateSummary()} Notes: {Notes}";
        }

        // Method to flag the item as critical, which adds a note and returns a new CriticalItem instance based on this item
        public CriticalItem FlagCritical(string flaggedBy)
        {
            AddNote(CriticalMsg, true);
            return new CriticalItem(this, flaggedBy);
        }
    }
}
