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

        public DateTime Hour { get; set; }

        public DateTime Minute { get; set; }

        public DateTime Second { get; set; }

        public Absence(Employee employee,
                       DateTime firstDay,
                       DateTime lastDay,
                       int idReason,
                       string justification
                       )
                       
        {
            Employee = employee;
            FirstDay = firstDay;
            LastDay = lastDay;
            IdReason = idReason;
            Justification = justification;
        }

        public Absence(Employee employee,
               DateTime firstDay,
               DateTime lastDay,
               int idReason,
               string justification,
               DateTime hour,
               DateTime minute,
               DateTime second
               )

        {
            Employee = employee;
            FirstDay = firstDay;
            LastDay = lastDay;
            IdReason = idReason;
            Justification = justification;
            Hour = hour;
            Minute = minute;
            Second = second;
        }

    }
}
