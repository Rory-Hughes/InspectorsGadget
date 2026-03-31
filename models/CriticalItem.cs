using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorsGadget.models
{
    // Requirement: Sealed Class - prevents further inheritance
    // Uses composition so any InspectionItem type can be glagged as critical without needing to modify the base class or derived classes
    public sealed class CriticalItem : InspectionItem
    {
        // Holds a reference to the original item that is flagged as critical
        public InspectionItem Source { get; private set; }
        public DateTime FlaggedDate { get; private set; }
        public string FlaggedBy { get; private set; }

        public CriticalItem(InspectionItem source, string flaggedBy)
            : base(source.ItemName, source.RepairCost)
        {
            Source = source ?? throw new ArgumentNullException(nameof(source));
            FlaggedBy = string.IsNullOrWhiteSpace(flaggedBy) ? throw new ArgumentException("Flagged by cannot be null or empty.") : flaggedBy;
            FlaggedDate = DateTime.Now;
            RiskLevel = source.RiskLevel; // Inherit risk level from the original item
            Notes = source.Notes; // Inherit notes from the original item
        }

        public override int CalculateRisk() => Source.CalculateRisk(); // Delegate risk calculation to the original item

        public override string GenerateSummary()
        {
            return Source.GenerateSummary() + $" | FLAGGED AS CRITICAL by {FlaggedBy} on {FlaggedDate:d}";
        }
    }
}
