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
            // The critical message is surfaced via the Critical Issues report section.
            return new CriticalItem(this, flaggedBy);
        }
    }
}

