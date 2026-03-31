using InspectorsGadget.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorsGadget.interfaces
{
    internal interface IReportable
    {
        string GenerateReport();
        CriticalItem FlagCritical(string flaggedBy);
    }
}
