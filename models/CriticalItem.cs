using InspectorsGadget.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorsGadget.models
{
    // Requirement: Sealed Class - prevents further inheritance
    // Uses composition so any InspectionItem type can be flagged as critical without needing to modify the base class or derived classes
    public sealed class CriticalItem : InspectionItem
    {
        private string _flaggedBy = InspectionManager.InspectorName; // Default to current inspector, but can be overridden in constructor

        // Holds a reference to the original item that is flagged as critical
        public InspectionItem Source { get; private set; }
        // Additional properties specific to critical items
        public DateTime FlaggedDate { get; private set; }
        public string FlaggedBy { get => _flaggedBy; private set => _flaggedBy = value; }
        // Constructor that initializes the critical item based on an existing inspection item and the inspector who flagged it
        public CriticalItem(InspectionItem source, string flaggedBy)
            : base(source.ItemName, source.RepairCost)
        {
            // We want to ensure that the source item is not null and that the flaggedBy parameter is valid, so we use the null-coalescing operator and a conditional check to assign these values.
            Source = source ?? throw new ArgumentNullException(nameof(source));
            // When creating a critical item, we want to ensure that the flaggedBy parameter is valid, so we check if it is null or whitespace and throw an exception if it is, otherwise we assign the value.
            FlaggedBy = string.IsNullOrWhiteSpace(flaggedBy) ? throw new ArgumentException("Flagged by cannot be null or empty.") : flaggedBy;
            // When a critical item is created, we want to set the flagged date to the current date and time, so we assign DateTime.Now to the FlaggedDate property.
            FlaggedDate = DateTime.Now;
            RiskLevel = source.RiskLevel; // Inherit risk level from the original item
            Notes = source.Notes; // Inherit notes from the original item
        }

        public override int CalculateRisk() => Source.CalculateRisk(); // Delegate risk calculation to the original item
        
        // Override the GenerateSummary method to include critical item details along with the original item's summary
        public override string GenerateSummary()
        {
            return Source.GenerateSummary() + $" | FLAGGED AS CRITICAL by {FlaggedBy} on {FlaggedDate:d}";
        }
    }
}
