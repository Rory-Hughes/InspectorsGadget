using InspectorsGadget.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorsGadget.models
{
    // Requirement: Abstract Base Class
    // Implements IComparable
    public abstract class InspectionItem : IComparable<InspectionItem>
    {
        // Requirement : Encapsulation - private backing fields with Properties
        private string _itemName;
        private decimal _repairCost;
        private int _riskLevel;
        private string _inspectedBy = InspectionManager.InspectorName;
        
        public string ItemName
        {
            get => _itemName;
            // when setting the item name we check if the value we are assigning is null or empty or just spaces
            // if it is we throw an exception, otherwise we assign the value 
            set => _itemName = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Item name cannot be null or empty.") : value;
        }

        public decimal RepairCost
        {
            get => _repairCost;
            // checking if value is greater than 0, my thinking is obviously you cant have a negative cost, but you could have possibly a cost of zero.
            // but in the case of a zero cost repair, that assumes something is an easy fix that practically any one could do in 10 minutes or less with no special tools
            // and some instructions so for this reason im assuming the inspector would just write a note about how to fix it and not assign a cost to it
            // hence why i am treating a zero cost as an invalid value for the repair cost
            set => _repairCost = value <= 0 ? throw new ArgumentOutOfRangeException(nameof(RepairCost), "Repair cost cannot be negative or free.") : value;
        }

        public int RiskLevel
        {
            get => _riskLevel;
            // when setting the risk level we want to ensure that the value is between 1 and 10, so we use Math.Clamp to restrict the value to this range.
            protected set => _riskLevel = Math.Clamp(value, 1, 10); // Ensure risk level is between 1 and 10
        }

        public string InspectedBy
        {             
            get => _inspectedBy;
        }

        public bool IsCritical => RiskLevel >= 8; // Consider items with risk level 8 or higher as critical
        // Auto-Implemented Property for notes
        public string Notes { get; set; } = string.Empty;

        // Constructor
        protected InspectionItem(string itemName, decimal repairCost)
        {
            // When creating a new inspection item, we want to ensure that the item name and repair cost are valid, so we use the property setters which include validation logic to assign these values.
            ItemName = itemName;
            RepairCost = repairCost;
        }

        // Requirement: Polymorphism - Abstract method to be implemented by derived classes
        public abstract int CalculateRisk();


        // Requirement: Method Overriding (virtual base for derived classes to override)
        public virtual string GenerateSummary()
        {
            // Format the summary to include type name, item name, risk level, repair cost
            return ToString(); // Use the overridden ToString method for a consistent summary format across all derived classes
        }

        // Requirement: Method Overloading - same method name, different signatures
        public void AddNote(string note)
        {
            if (note.Contains(","))
            {    
                note = note.Replace(",", " | "); // Replace commas with a separator for better readability in the notes so loading doesnt get messed up with .csv files that use commas to separate fields
            }

            // if this is the first note, just assign it; otherwise, append with a separator
            // default behavior is to append notes, but if the user wants to overwrite existing notes they can use the overloaded method with the overwrite parameter set to true
            if (Notes == string.Empty)
            {
                Notes = note;
            }
            else
            {
                Notes += " | " + note;
            }
        }

        public void AddNote(string note, bool overWrite)
        {

            if (note.Contains(","))
            {
                note = note.Replace(",", " | "); // Replace commas with a separator for better readability in the notes so loading doesnt get messed up with .csv files that use commas to separate fields
            }
            // If overwrite is true, replace existing notes; otherwise, append with a separator
            if (overWrite)
            {
                Notes = note;
            } else
            {
                Notes += " | " + note;
            }
        }

        // Requirement: Operator Overloading - sum of repair costs for two inspection items
        public static decimal operator + (InspectionItem a, InspectionItem b)
        {
            return a.RepairCost + b.RepairCost;
        }
        
        // Requirement: Built-in .NET Interface - IComparable for sorting by risk level
        public int CompareTo(InspectionItem? other)
        {
            if (other == null) return 1; // Current instance is greater than null
            return RiskLevel.CompareTo(other.RiskLevel); // Sort by risk level
        }

        // Override ToString to provide a meaningful string representation of the inspection item
        public override string ToString()
        {
            return $"[{GetType().Name}] {ItemName} | Risk: {RiskLevel}/10 | Est. Cost: ${RepairCost:F2}";
        }
    }
}
