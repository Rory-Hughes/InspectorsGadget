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
            // Initialize specific properties for ApplianceItem
            AgeInYears = ageInYears;
            IsOperational = isOperational;
            RiskLevel = CalculateRisk(); // Set risk level based on specific criteria
        }
        // Override the CalculateRisk method to determine risk level based on appliance age and operational status
        public override int CalculateRisk()
        {
            int risk = IsOperational ? 1 : 5; // Base risk level 1 for operational, 5 for non-operational
            if (AgeInYears > 15) risk += 3; // Older appliances increase risk
            if (risk >= 8) FlagCritical(base.InspectedBy); // Automatically flag as critical if risk is 8 or higher
            return Math.Clamp(risk, 1, 10); // Ensure risk level is between 1 and 10
        }
        // Override the GenerateSummary method to include specific details about the appliance item
        public override string GenerateSummary()
        {
            return base.GenerateSummary() + $" | Age: {AgeInYears} years | Operational: {IsOperational}";
        }

        // Requirement: IReportable Interface
        public string GenerateReport()
        {
            return $"Appliance Item Report {GenerateSummary()} Notes: {Notes}";
        }

        // Method to flag the item as critical, which adds a note and returns a new CriticalItem instance based on this item
        public CriticalItem FlagCritical(string flaggedBy)
        {
            AddNote("CRITICAL: Repair or replace appliance as soon as possible!", true);
            return new CriticalItem(this, flaggedBy);
        }
    }
}
