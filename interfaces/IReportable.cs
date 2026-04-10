using InspectorsGadget.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorsGadget.interfaces
{
    // Requirement: Interface - IReportable defines a contract for generating reports and flagging critical items
    internal interface IReportable
    {
        // Method to generate a detailed report of the item, which can be implemented by different types of inspection items to provide specific reporting details
        string GenerateReport();
        
        // Method to flag the item as critical, which can be implemented by different types of inspection items to add a critical note and return a new CriticalItem instance based on the original item
        CriticalItem FlagCritical(string flaggedBy);
    }
}
