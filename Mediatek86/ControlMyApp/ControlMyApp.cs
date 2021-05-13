using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mediatek86.dal;
using Mediatek86.Model;
using Mediatek86.View;

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


        public static int GetMaxEmployeeID()
        {
            return AccessDataBase.GetMaxEmployeeID();
        }

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

        public void RemoveEmployeeFromEmployee(Employee employee)
        {
            AccessDataBase.RemoveEmployeeFromEmployee(employee);
        }

        public void RemoveEmployeeFromAbsence(Employee employee)
        {
            AccessDataBase.RemoveEmployeeFromAbsence(employee);
        }

        public void OpenAbsence(Employee employee)
        {
            new FrmManageAbsence(this, employee).ShowDialog();
        }

        public List<Absence> GetTheAbsences(Employee employee)
        {
           return AccessDataBase.GetTheAbsences(employee);
        }

        public List<Reason> GetTheReasons()
        {
            return AccessDataBase.GetTheReasons();
        }


        public void AddAbsence(Employee employee, DateTime firstDay, DateTime lastDay, int idReason)
        {
            AccessDataBase.AddAbsence(employee, firstDay, lastDay, idReason);
        }

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

        public void RemoveAbsenceFromEmployee(Absence absence, Employee _employee)
        {
            AccessDataBase.RemoveAbsenceFromEmployee(absence, _employee);
        }


        public bool AbsenceAtTheEndOfTheCalendar(Employee employee, DateTime firstDay)
        {
            DateTime maxDay = AccessDataBase.AbsenceAtTheEndOfTheCalendar(employee);
            return firstDay > maxDay;

        }

        public bool LastDayIsBeforeNextAbsence(Employee employee, 
                                                                DateTime firstDaySelected, 
                                                                DateTime lastDaySelected)
        {
            DateTime firstDayNextAbsence = AccessDataBase.LastDayIsBeforeNextAbsence(employee, firstDaySelected);

            return lastDaySelected < firstDayNextAbsence;
        }

        public bool FirstDayIsAfterPreviousAbsence(Employee employee, 
                                                   DateTime firstDaySelected
                                                   )
        {
            DateTime lastDayPreviousAbsence = AccessDataBase.FirstDayIsAfterPreviousAbsence(employee, firstDaySelected);

            return lastDayPreviousAbsence < firstDaySelected;
        }
    }
}
