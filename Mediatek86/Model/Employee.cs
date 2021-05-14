/// <summary>
/// Model in the MVC conception for the Employee
/// </summary>
namespace Mediatek86.Model
{
    /// <summary>
    /// To get access and modify the requested data stored in the table employee
    /// </summary>
    public class Employee
    {

        /// <summary>
        /// Only a getter as this field is the primary key from the table employee
        /// </summary>
        public int IdEmployee { get; }

        /// <summary>
        /// Getter and setter for the department from which belongs the employee
        /// It is the foreign key which refers to the table department
        /// </summary>
        public int IdDepartment { get; set; }

        /// <summary>
        /// Getter and setter for the field corresponding to the employee family name
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// Getter and setter for the field corresponding to the employee first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Getter and setter for the field corresponding to the employee phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Getter and setter for the field corresponding to the employee mail
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Only a getter as the name of department should not be modified
        /// </summary>
        public string DepartmentName { get; }

        /// <summary>
        /// Constructor of the class EMployee
        /// </summary>
        /// <param name="idEmployee">ID of the employee</param>
        /// <param name="familyName">family name of the employee</param>
        /// <param name="firstName">first name of the employee</param>
        /// <param name="phone">phone number of the employee</param>
        /// <param name="mail">mail of the employee</param>
        /// <param name="idDepartment">ID number of the department</param>
        /// <param name="departmentName">name of the department</param>
        public Employee(int idEmployee,
                        string familyName,
                        string firstName,
                        string phone,
                        string mail,
                        int idDepartment,
                        string departmentName
                        )
        {
            IdEmployee = idEmployee;
            FamilyName = familyName;
            FirstName = firstName;
            Phone = phone;
            Mail = mail;
            IdDepartment = idDepartment;
            DepartmentName = departmentName;
        }
    }
}
