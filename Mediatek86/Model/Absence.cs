using System;

/// <summary>
/// Model in the MVC conception for the Absence
/// </summary>
namespace Mediatek86.Model
{
    /// <summary>
    /// To get access and modify the requested data stored in the table absence 
    /// </summary>
    public class Absence
    {
    
        /// <summary>
        /// Get the employee (object) corresponding to the absence
        /// </summary>
        public Employee Employee { get;}
         
        /// <summary>
        /// Property (getter and setter) for the ID of the reason
        /// </summary>
        public int IdReason { get; set; }

        /// <summary>
        /// Property (getter and setter) for the first day of the absence
        /// </summary>
        public DateTime FirstDay { get; set; }

        /// <summary>
        /// Property (getter and setter) for the last day of the absence
        /// </summary>
        public DateTime LastDay { get; set; }

        /// <summary>
        /// Get the name (justification) of the absence
        /// </summary>
        public string Justification { get; }

        /// <summary>
        /// Property (getter and setter) for the hour of the absence
        /// </summary>
        public DateTime Hour { get; set; }

        /// <summary>
        /// Property (getter and setter) for the minute of the absence
        /// </summary>
        public DateTime Minute { get; set; }

        /// <summary>
        /// Property (getter and setter) for the second of the absence
        /// </summary>
        public DateTime Second { get; set; }

        /// <summary>
        /// first constructor (to fill the datagridview)
        /// </summary>
        /// <param name="employee">Employee (object) from who the absence corresponds</param>
        /// <param name="firstDay">first day of the absence</param>
        /// <param name="lastDay">last day of the absence</param>
        /// <param name="idReason">ID reason of the absence</param>
        /// <param name="justification">Reason (justification) of the absence</param>
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

        /// <summary>
        /// second constructor (to create an object after modifying the first day and last day)
        /// </summary>
        /// <param name="employee">Employee (object) from who the absence corresponds</param>
        /// <param name="firstDay">first day of the absence</param>
        /// <param name="lastDay">last day of the absence</param>
        /// <param name="idReason">ID reason of the absence</param>
        /// <param name="justification">Reason (justification) of the absence</param>
        /// <param name="hour">hour of the absence day</param>
        /// <param name="minute">minute of the absence day</param>
        /// <param name="second">minute of the absence day</param>
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
