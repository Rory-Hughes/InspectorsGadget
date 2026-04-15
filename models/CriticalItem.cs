using InspectorsGadget.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorsGadget.models
{

    // Requirement: Sealed Class
    public sealed class CriticalItem : InspectionItem
    {
        public InspectionItem Source { get; private set; }
        public DateTime FlaggedDate { get; private set; }
        public string FlaggedBy { get; private set; }

        // Main constructor — used when flagging at runtime.
        public CriticalItem(InspectionItem source, string flaggedBy)
            : base(source?.ItemName ?? throw new ArgumentNullException(nameof(source)),
                   source.RepairCost)
        {
            Source = source;
            FlaggedBy = string.IsNullOrWhiteSpace(flaggedBy)
                ? throw new ArgumentException("Flagged by cannot be null or empty.")
                : flaggedBy;
            FlaggedDate = DateTime.Now;
            RiskLevel = source.RiskLevel;
            Notes = source.Notes; // snapshot of user notes only (no CRITICAL message)
        }

        // Overload used when loading from file — preserves the original flagged date.
        public CriticalItem(InspectionItem source, string flaggedBy, DateTime flaggedDate)
            : this(source, flaggedBy)
        {
            FlaggedDate = flaggedDate; // override the DateTime.Now set above
        }

        public override int CalculateRisk() => Source.CalculateRisk();

        public override string GenerateSummary()
        {
            return Source.GenerateSummary()
                + $" | FLAGGED AS CRITICAL by {FlaggedBy} on {FlaggedDate:d}";
        }
    }
}