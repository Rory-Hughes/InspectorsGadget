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
            int risk = HasGrounding ? 2 : 7; // Base risk level
            if (AmpRating > 200) risk += 2; // Higher amp rating increases risk
            if (!HasGrounding) risk += 4; // Lack of grounding significantly increases risk
            return Math.Clamp(risk, 1, 10); // Ensure risk level is between 1 and 10
        }

        public override string GenerateSummary()
        {
            
            return base.GenerateSummary() + $" | Grounded: {HasGrounding} | Amps: {AmpRating}";
        }

        // Requirement: IReportable Interface
        public string GenerateReport()
        {
            return $"Electrical Item Report {GenerateSummary()} Notes: {Notes}";
        }

        public void FlagCritical()
        {
            if (IsCritical)
            {
                AddNote("CRITICAL: Immediate electrical attention required!", true);
            }
        }
    }
}
