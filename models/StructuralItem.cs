using InspectorsGadget.helpers;
using InspectorsGadget.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorsGadget.models
{
    public class StructuralItem : InspectionItem, IReportable
    {

        public bool HasVisibleCracks { get; set; }
        public bool HasWaterDamage { get; set; }

        public StructuralItem(string itemName, decimal repairCost, bool hasVisibleCracks, bool hasWaterDamage)
            : base(itemName, repairCost)
        {
            HasVisibleCracks = hasVisibleCracks;
            HasWaterDamage = hasWaterDamage;
            RiskLevel = CalculateRisk();
        }

        public override int CalculateRisk()
        {
            int risk = 1;
            if (HasVisibleCracks) risk += 4;
            if (HasWaterDamage) risk += 3;

            // Auto-flag: guard null InspectorName, add to CriticalItems (not Items).
            if (risk >= 8 && !string.IsNullOrWhiteSpace(base.InspectedBy))
                InspectionManager.AddCriticalItem(FlagCritical(base.InspectedBy));

            return Math.Clamp(risk, 1, 10);
        }

        public override string GenerateSummary()
            => base.GenerateSummary() + $" | Has Visible Cracks: {HasVisibleCracks} | Has Water Damage: {HasWaterDamage}";

        public string GenerateReport()
            => $"Structural Item Report {GenerateSummary()} Notes: {Notes}";

        public CriticalItem FlagCritical(string flaggedBy)
        {
            // NOTE: no AddNote(CriticalMsg) here — source item notes stay clean.
            return new CriticalItem(this, flaggedBy);
        }
    }
}



/*
// Requirement: Inheritance - StructuralItem inherits from InspectionItem
// Requirement: Additional properties specific to StructuralItem
public bool HasVisibleCracks { get; set; }
        public bool HasWaterDamage { get; set; }

        private string CriticalMsg { get; } = "CRITICAL: Structural integrity at risk! immediate attention required!";

        // Constructor that initializes base properties and specific properties for StructuralItem
        public StructuralItem(string itemName, decimal repairCost, bool hasVisibleCracks, bool hasWaterDamage)
            : base(itemName, repairCost)
        {
            HasVisibleCracks = hasVisibleCracks;
            HasWaterDamage = hasWaterDamage;
            RiskLevel = CalculateRisk(); // Set risk level based on specific criteria
            addCritical(RiskLevel, InspectedBy); // Automatically flag as critical if risk is 8 or higher
        }

        // Override the CalculateRisk method to determine risk level based on structural issues
        public override int CalculateRisk()
        {
            int risk = 1; // Base risk level
            if (HasVisibleCracks) risk += 4; // Visible cracks significantly increase risk
            if (HasWaterDamage) risk += 3; // Water damage also significantly increases risk
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
            AddNote(CriticalMsg);
            return new CriticalItem(this, flaggedBy);
        }

        public void addCritical(int riskLevel, string flaggedBy)
        {
            if (riskLevel >= 8)
            {
                var critical = FlagCritical(flaggedBy);
                InspectionManager.AddItem(critical);
            }
        }
    }
}
*/