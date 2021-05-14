using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mediatek86.dal;
using Mediatek86.Model;
using Mediatek86.View;

/// <summary>
/// Control class in MVC conception to make the link between View and Model
/// </summary>
namespace Mediatek86.Control
{
    /// <summary>
    /// Class which control the instantiation of the authentification form
    /// </summary>
    public class ControlMyApp
    {
        private readonly FrmAuthentification FrmAuthentification;

        /// <summary>
        /// Contructor which will create an instance of the authentification form
        /// </summary>
        public ControlMyApp()
        {
            FrmAuthentification = new FrmAuthentification(this);
            FrmAuthentification.ShowDialog();

        }

        /// <summary>
        /// Control that the input given by the manager fits with the input stored in the database
        /// </summary>
        /// <param name="login">user login</param>
        /// <param name="password">user password</param>
        /// <returns>true if the authentification is successfull</returns>
        public Boolean ControlAuthentification(string login, string password)
        {
            if (AccessDataBase.ControlAuthentification(login, password))
            {
                FrmAuthentification.Hide();
                (new FrmEmployee(this)).ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get and return the data from the employee coming from the database
        /// </summary>
        /// <returns>list of employees</returns>
        public List<Employee> GetTheEmployees()
        {
            return AccessDataBase.GetTheEmployees();
        }

        /// <summary>
        /// Get and return the list of departments stored in the database
        /// </summary>
        /// <returns>list of department</returns>
        public List<Department> GetTheDepartments()
        {
            return AccessDataBase.GetTheDepartments();
        }


        /// <summary>
        /// Get the maximum ID for the employee table
        /// </summary>
        /// <returns>integer (ID) corresponding to the last employee</returns>
        public static int GetMaxEmployeeID()
        {
            return AccessDataBase.GetMaxEmployeeID();
        }


        /// <summary>
        /// Method to add an employee in the database
        /// </summary>
        /// <param name="idEmployee">id number of the employee</param>
        /// <param name="familyName">family name</param>
        /// <param name="firstName">first name</param>
        /// <param name="phone">phone number</param>
        /// <param name="mail">mail</param>
        /// <param name="idDepartment">id number of the department</param>
        /// <param name="departmentName">name of the department</param>
        public void AddEmployee(int idEmployee,
                        string familyName,
                        string firstName,
                        string phone,
                        string mail,
                        int idDepartment,
                        string departmentName
                        )
        {
            Employee employee = new Employee(idEmployee,
                                             familyName,
                                             firstName,
                                             phone,
                                             mail,
                                             idDepartment,
                                             departmentName);

            AccessDataBase.AddEmployee(employee);

        }

        /// <summary>
        /// Method to update an employee in the database
        /// </summary>
        /// <param name="employee">Employee (objet) previously selected</param>
        /// <param name="familyName">family name selected in its corresponding TextBox</param>
        /// <param name="firstName">first name selected in its corresponding TextBox</param>
        /// <param name="phone">phone selected in its corresponding TextBox</param>
        /// <param name="mail">mail selected in its corresponding TextBox</param>
        /// <param name="idDepartment">ID number of the selected department in the ComboBox</param>
        public void UpdateEmployee(Employee employee,
                                           string familyName,
                                           string firstName,
                                           string phone,
                                           string mail,
                                           int idDepartment)
        {
            employee.FamilyName = familyName;
            employee.FirstName = firstName;
            employee.Phone = phone;
            employee.Mail = mail;
            employee.IdDepartment = idDepartment;
            AccessDataBase.UpdateEmployee(employee);
        }

        /// <summary>
        /// Method to remove an employee in the database for the table EMPLOYEE
        /// </summary>
        /// <param name="employee">Employee (objet) previously selected</param>
        public void RemoveEmployeeFromEmployee(Employee employee)
        {
            AccessDataBase.RemoveEmployeeFromEmployee(employee);
        }

        /// <summary>
        /// Method to remove an employee in the database for the table ABSENCE
        /// </summary>
        /// <param name="employee">Employee (objet) previously selected</param>
        public void RemoveEmployeeFromAbsence(Employee employee)
        {
            AccessDataBase.RemoveEmployeeFromAbsence(employee);
        }

        /// <summary>
        /// Create a new Windows Form for the absence corresponding to the Employee preselected
        /// </summary>
        /// <param name="employee">Employee (objet) previously selected</param>
        public void OpenAbsence(Employee employee)
        {
            new FrmManageAbsence(this, employee).ShowDialog();
        }

        /// <summary>
        /// Get the list of absences corresponding to a specific employee
        /// </summary>
        /// <param name="employee">Employee (objet) previously selected</param>
        /// <returns>List of the absences</returns>
        public List<Absence> GetTheAbsences(Employee employee)
        {
           return AccessDataBase.GetTheAbsences(employee);
        }

        /// <summary>
        /// Get the list of absence reasons for the ComboBox
        /// </summary>
        /// <returns>List of the reasons of the absence</returns>
        public List<Reason> GetTheReasons()
        {
            return AccessDataBase.GetTheReasons();
        }

        /// <summary>
        /// Method to add an absence from an employee to the database
        /// </summary>
        /// <param name="employee">Employee (objet) previously selected</param>
        /// <param name="firstDay">first day of the absence selected in the DateTimePicker</param>
        /// <param name="lastDay">last day of the absence selected in the DateTimePicker</param>
        /// <param name="idReason">ID reason of the absence</param>
        public void AddAbsence(Employee employee, DateTime firstDay, DateTime lastDay, int idReason)
        {
            AccessDataBase.AddAbsence(employee, firstDay, lastDay, idReason);
        }

        /// <summary>
        /// Check that the first day selected is before the last day selected
        /// </summary>
        /// <param name="firstDay">first day of the absence selected in the DateTimePicker</param>
        /// <param name="lastDay">last day of the absence selected in the DateTimePicker</param>
        /// <returns>boolean (true if selection correct), false if not</returns>
        public bool FirstDayPredateLastDate(DateTime firstDay, DateTime lastDay)
        {
            if (lastDay < firstDay)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Check that the first day which composes the composite primary key from ABSENCE has never been selected
        /// </summary>
        /// <param name="day">first day selected in the DateTimePicker</param>
        /// <param name="dataGridViewAbsence">datagridview of the absence</param>
        /// <returns>boolean (true if first day never picked, false if not)</returns>
        public bool FirstDayWasNeverPicked(DateTime day, DataGridView dataGridViewAbsence)
        {
            foreach (DataGridViewRow row in dataGridViewAbsence.Rows)
            {
                if (row.Cells["FirstDay"].Value.Equals(day))
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        ///  Method to update an absence from an employee in the database
        /// </summary>
        /// <param name="employee">Employee (objet) previously selected</param>
        /// <param name="previousDateSelected">first day selected (primary key) before the modification</param>
        /// <param name="firstDay">first day selected in the DateTimePicker</param>
        /// <param name="lastDay">last day selected in the DateTimePicker</param>
        /// <param name="idReason">ID reason of the absence</param>
        public void UpdateAbsence(Employee employee, 
                                  DateTime previousDateSelected,
                                  DateTime firstDay, 
                                  DateTime lastDay, 
                                  int idReason
                                  )
        {
            AccessDataBase.UpdateAbsence(employee, 
                                         previousDateSelected, 
                                         firstDay, 
                                         lastDay, 
                                         idReason
                                        );
        }

        /// <summary>
        /// Remove an absence for an employee
        /// </summary>
        /// <param name="absence">Absence (object)</param>
        /// <param name="_employee">Employee (object)</param>
        public void RemoveAbsenceFromEmployee(Absence absence, Employee _employee)
        {
            AccessDataBase.RemoveAbsenceFromEmployee(absence, _employee);
        }


        /// <summary>
        /// Check if the absence selected falls at the end of the absence list
        /// </summary>
        /// <param name="employee">Employee (object) selected</param>
        /// <param name="firstDay">first day selected in the DateTimePicker</param>
        /// <returns>boolean (true if the absence falls at the end of all previous absence, false if not)</returns>
        public bool AbsenceAtTheEndOfTheCalendar(Employee employee, DateTime firstDay)
        {
            DateTime maxDay = AccessDataBase.AbsenceAtTheEndOfTheCalendar(employee);
            return firstDay > maxDay;

        }

        /// <summary>
        /// Check if the last day absence selected falls before the next absence already set
        /// </summary>
        /// <param name="employee">Employee (object) selected</param>
        /// <param name="firstDaySelected">First day selected in the DateTimePicker</param>
        /// <param name="lastDaySelected">Last day selected in the DateTimePicker</param>
        /// <returns>boolean (true if last day absence selected falls before the next absence already set, false if not)</returns>
        public bool LastDayIsBeforeNextAbsence(Employee employee, 
                                                                DateTime firstDaySelected, 
                                                                DateTime lastDaySelected)
        {
            DateTime firstDayNextAbsence = AccessDataBase.LastDayIsBeforeNextAbsence(employee, firstDaySelected);

            return lastDaySelected < firstDayNextAbsence;
        }

        /// <summary>
        /// Check if the first day selected falls after the previous absence already set
        /// </summary>
        /// <param name="employee">Employee (object) selected</param>
        /// <param name="firstDaySelected">First day selected in the DateTimePicker</param>
        /// <returns>boolean (true if first day absence selected falls after the previous absence already set, false if not)</returns>
        public bool FirstDayIsAfterPreviousAbsence(Employee employee, 
                                                   DateTime firstDaySelected
                                                   )
        {
            DateTime lastDayPreviousAbsence = AccessDataBase.FirstDayIsAfterPreviousAbsence(employee, firstDaySelected);

            return lastDayPreviousAbsence < firstDaySelected;
        }
    }
}
