using System;

namespace Mediatek86.Model
{
    /// <summary>
    /// To get access and modify the requested data stored in the table absence 
    /// </summary>
    public class Absence
    {
        private int _idReason;
        private DateTime _firstDay;
        private DateTime _lastDay;

        /// <summary>
        /// Getter and setter for the reason of the absence
        /// </summary>
        public int IdReason { get => _idReason; set => _idReason = value; }

        /// <summary>
        /// Getter and setter for the first day of the absence
        /// </summary>
        public DateTime FirstDay { get => _firstDay; set => _firstDay = value; }

        /// <summary>
        /// Getter and setter for the last day of the absence
        /// </summary>
        public DateTime LastDay { get => _lastDay; set => _lastDay = value; }

        /// <summary>
        /// Only a getter as this field is part of the primary key from the table absence
        /// and at the same time the foreign key which refers to the table Employee
        /// </summary>
        public int IdEmployee { get; }

        /// <summary>
        /// Getter on the family name of the employee
        /// </summary>
        public string FamilyName { get; }

        /// <summary>
        /// Getter on the first name of the employee
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Getter on the reason / justification of the absence
        /// </summary>
        public string Justification { get; }

        /// <summary>
        /// Getter on the department number of the employee
        /// </summary>
        public int IdDepartment { get; }

        /// <summary>
        /// Getter on the department name from which belongs the employee
        /// </summary>
        public string DepartmentName { get; }

        /// <summary>
        /// Constructor of the class absence
        /// </summary>
        /// <param name="idEmployee">idEmployee is a part of the primary key for the table absence</param>
        /// <param name="idReason">idReason reprends the foreign key for the table reason</param>
        /// <param name="firstDay">firstDay is a field of the table absence. Its represents the first day the employee being absent</param>
        /// <param name="lastday">lastDay is a field of the table absence. Its represents the last day the employee being absent</param>
        public Absence(int idEmployee, 
                       string familyName, 
                       string firstName, 
                       int idReason, 
                       string justification,
                       int idDepartment,
                       string departmentName,
                       DateTime firstDay, 
                       DateTime lastday)
        {
            _idReason = idReason;
            _firstDay = firstDay;
            _lastDay = lastday;
            IdEmployee = idEmployee;
            IdDepartment = idDepartment;
            DepartmentName = departmentName;
            FamilyName = familyName;
            FirstName = firstName;
            Justification = justification;
        }
    }
}
