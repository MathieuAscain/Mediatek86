using System;
using System.Collections.Generic;
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

        /// <summary>
        ///  Request to remove an employee
        /// </summary>
        /// <param name="employee">employee to be removed from the list</param>
        public void RemoveEmployeeFromAbsence(Employee employee)
        {
            AccessDataBase.RemoveEmployeeFromAbsence(employee);
        }
      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public void RemoveEmployeeFromEmployee(Employee employee)
        {
            AccessDataBase.RemoveEmployeeFromEmployee(employee);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public void UpdateEmployee(Employee employee)
        {
            AccessDataBase.UpdateEmployee(employee);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public void AddModifiedEmployee(Employee employee)
        {
            AccessDataBase.AddModifiedEmployee(employee);
        }

    }
}
