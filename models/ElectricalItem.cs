using InspectorsGadget.helpers;
using InspectorsGadget.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorsGadget.models
{
    // Requirement: Derived Class - ElectricalItem inheriting from abstract base
    public class ElectricalItem : InspectionItem, IReportable
    {

        public int AmpRating { get; set; }
        public bool HasGrounding { get; set; }

        public ElectricalItem(string itemName, decimal repairCost, int ampRating, bool hasGrounding)
            : base(itemName, repairCost)
        {
            AmpRating = ampRating;
            HasGrounding = hasGrounding;
            RiskLevel = CalculateRisk();
        }

        public override int CalculateRisk()
        {
            int risk = 1;
            if (AmpRating > 25) risk += 3;
            if (!HasGrounding) risk += 4;

            // Auto-flag: guard null InspectorName, add to CriticalItems (not Items).
            if (risk >= 8 && !string.IsNullOrWhiteSpace(base.InspectedBy))
                InspectionManager.AddCriticalItem(FlagCritical(base.InspectedBy));

            return Math.Clamp(risk, 1, 10);
        }

        public override string GenerateSummary()
            => base.GenerateSummary() + $" | Grounded: {HasGrounding} | Amps: {AmpRating}";

        public string GenerateReport()
            => $"Electrical Item Report {GenerateSummary()} Notes: {Notes}";

        public CriticalItem FlagCritical(string flaggedBy)
        {
            // NOTE: no AddNote(CriticalMsg) here — source item notes stay clean.
            // The critical message is surfaced via the Critical Issues report section.
            return new CriticalItem(this, flaggedBy);
        }
    }
}

/*
public int AmpRating { get; set; }
        public bool HasGrounding { get; set; }

        private string CriticalMsg { get; } = "CRITICAL: Immediate electrical attention required!";

        // Constructor that initializes base properties and specific properties for ElectricalItem
        public ElectricalItem(string itemName, decimal repairCost, int ampRating, bool hasGrounding)
            : base(itemName, repairCost)
        {
            AmpRating = ampRating;
            HasGrounding = hasGrounding;
            RiskLevel = CalculateRisk(); // Set risk level based on specific criteria
            addCritical(RiskLevel, InspectedBy); // Automatically flag as critical if risk is 8 or higher
        }

        // Requirement: Abstract Method Implementation + Method Overriding

        public override int CalculateRisk()
        {
            int risk = 1; // Base risk level
            if (AmpRating > 25) risk += 3; // Higher amp rating increases risk
            if (!HasGrounding) risk += 4; // Lack of grounding significantly increases risk
            return Math.Clamp(risk, 1, 10); // Ensure risk level is between 1 and 10
        }

        // Override the GenerateSummary method to include specific details about the electrical item
        public override string GenerateSummary()
        {
            
            return base.GenerateSummary() + $" | Grounded: {HasGrounding} | Amps: {AmpRating}";
        }

        // Requirement: IReportable Interface
        public string GenerateReport()
        {
            return $"Electrical Item Report {GenerateSummary()} Notes: {Notes}";
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