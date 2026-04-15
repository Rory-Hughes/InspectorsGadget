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
            return new CriticalItem(this, flaggedBy);
        }
    }
}