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
        public bool HasVisibleCracks { get; set; }
        public bool HasWaterDamage { get; set; }

        public StructuralItem(string itemName, decimal repairCost, bool hasVisibleCracks, bool hasWaterDamage)
            : base(itemName, repairCost)
        {
            HasVisibleCracks = hasVisibleCracks;
            HasWaterDamage = hasWaterDamage;
            RiskLevel = CalculateRisk(); // Set risk level based on specific criteria
        }

        public override int CalculateRisk()
        {
            int risk = 1; // Base risk level
            if (HasVisibleCracks) risk += 4; // Visible cracks significantly increase risk
            if (HasWaterDamage) risk += 3; // Water damage also significantly increases risk
            return Math.Clamp(risk, 1, 10); // Ensure risk level is between 1 and 10
        }

        public override string GenerateSummary()
        {
            return base.GenerateSummary() + $" | Has Visible Cracks: {HasVisibleCracks} | Has Water Damage: {HasWaterDamage}";
        }

        public string GenerateReport()
        {
            return $"Structural Item Report {GenerateSummary()} Notes: {Notes}";
        }

        public CriticalItem FlagCritical(string flaggedBy)
        {
            AddNote("CRITICAL: Structural integrity at risk, immediate attention required!", true);
            return new CriticalItem(this, flaggedBy);
        }
    }
}
