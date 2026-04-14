using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorsGadget.interfaces;

namespace InspectorsGadget.models
{
    // Requirement: Derived Class - ElectricalItem inheriting from abstract base
    public class ElectricalItem : InspectionItem, IReportable
    {
        public int AmpRating { get; set; }
        public bool HasGrounding { get; set; }

        // Constructor that initializes base properties and specific properties for ElectricalItem
        public ElectricalItem(string itemName, decimal repairCost, int ampRating, bool hasGrounding)
            : base(itemName, repairCost)
        {
            AmpRating = ampRating;
            HasGrounding = hasGrounding;
            RiskLevel = CalculateRisk(); // Set risk level based on specific criteria
        }

        // Requirement: Abstract Method Implementation + Method Overriding

        public override int CalculateRisk()
        {
            int risk = 1; // Base risk level
            if (AmpRating > 25) risk += 3; // Higher amp rating increases risk
            if (!HasGrounding) risk += 4; // Lack of grounding significantly increases risk
            if (risk >= 8) FlagCritical(base.InspectedBy); // Automatically flag as critical if risk is 8 or higher
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
            AddNote("CRITICAL: Immediate electrical attention required!", true);
            return new CriticalItem(this, flaggedBy);
        }
    }
}
