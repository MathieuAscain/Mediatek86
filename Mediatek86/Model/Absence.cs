using System;
using Mediatek86.View;

namespace Mediatek86.Model
{
    /// <summary>
    /// To get access and modify the requested data stored in the table absence 
    /// </summary>
    public class Absence
    {
    
        public Employee Employee { get;}
            
        public int IdReason { get; set; }

        public DateTime FirstDay { get; set; }

        public DateTime LastDay { get; set; }

        public string Justification { get; }

        public Absence(Employee employee, 
                       DateTime firstDay, 
                       DateTime lastDay, 
                       int idReason,
                       string justification)
                       
        {
            Employee = employee;
            FirstDay = firstDay;
            LastDay = lastDay;
            IdReason = idReason;
            Justification = justification; 
        }
    }
}
