using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorsGadget.helpers;
using InspectorsGadget.interfaces;

namespace InspectorsGadget.models
{
    public class ApplianceItem : InspectionItem, IReportable
    {
        public int AgeInYears { get; set; }
        public bool IsOperational { get; set; }

        public ApplianceItem(string itemName, decimal repairCost, int ageInYears, bool isOperational)
            : base(itemName, repairCost)
        {
            AgeInYears = ageInYears;
            IsOperational = isOperational;
            RiskLevel = CalculateRisk();
        }

        public override int CalculateRisk()
        {
            int risk = IsOperational ? 1 : 5;
            if (AgeInYears > 15) risk += 3;

            if (risk >= 8 && !string.IsNullOrWhiteSpace(base.InspectedBy))
                InspectionManager.AddCriticalItem(FlagCritical(base.InspectedBy));

            return Math.Clamp(risk, 1, 10);
        }

        public override string GenerateSummary()
            => base.GenerateSummary() + $" | Age: {AgeInYears} years | Operational: {IsOperational}";

        public string GenerateReport()
            => $"Appliance Item Report {GenerateSummary()} Notes: {Notes}";

        public CriticalItem FlagCritical(string flaggedBy)
        {
            return new CriticalItem(this, flaggedBy);
        }
    }
}