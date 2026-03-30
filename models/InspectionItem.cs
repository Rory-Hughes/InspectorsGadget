using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorsGadget.models
{
    // Requirement: Abstract Base Class
    public abstract class InspectionItem : IComparable<InspectionItem>  
    {
        // Requirement : Encapsulation - private backing fields with Properties
        private string _itemName;
        private decimal _repairCost;
        private int _riskLevel;

        public string ItemName
        {
            get => _itemName;
            set => _itemName = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Item name cannot be null or empty.") : value;
        }

        public decimal RepairCost
        {
            get => _repairCost;
            set => _repairCost = value < 0 ? throw new ArgumentOutOfRangeException(nameof(RepairCost), "Repair cost cannot be negative.") : value;
        }

        public int RiskLevel
        {
            get => _riskLevel;
            protected set => _riskLevel = Math.Clamp(value, 1, 10); // Ensure risk level is between 1 and 10
        }

        public bool IsCritical => RiskLevel >= 8; // Consider items with risk level 8 or higher as critical

        public string Notes { get; set; } = string.Empty;

        // Constructor
        protected InspectionItem(string itemName, decimal repairCost)
        {
            ItemName = itemName;
            RepairCost = repairCost;
        }

        // Requirement: Polymorphism - Abstract method to be implemented by derived classes
        public abstract int CalculateRisk();

        // Requirement: Method Overriding (virtual base for derived classes to override)
        public virtual string GenerateSummary()
        {
            return $"[{GetType().Name}] {ItemName} | Risk: {RiskLevel}/10 | Est. Cost: ${RepairCost:F2}";
        }

        // Requirement: Method Overloading - same method name, different signatures
        public void AddNote(string note)
        {
            Notes = note;
        }

        public void AddNote(string note, bool overwrite)
        {
            Notes = overwrite ? note : Notes + " | " + note;
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

        public override string ToString()
        {
            return GenerateSummary();
        }
    }
}
