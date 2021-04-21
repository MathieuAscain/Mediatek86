
namespace Mediatek86.Model
{
    /// <summary>
    /// To get access and modify the requested data stored in the table employee
    /// </summary>
    public class Employee
    {
        private int _idDepartment;
        private string _familyName;
        private string _firstName;
        private string _phone;
        private string _mail;

        /// <summary>
        /// Only a getter as this field is the primary key from the table employee
        /// </summary>
        public int IdEmployee { get; }

        /// <summary>
        /// Getter and setter for the department from which belongs the employee
        /// It is the foreign key which refers to the table department
        /// </summary>
        public int IdDepartment { get => _idDepartment; set => _idDepartment = value; }

        /// <summary>
        /// Getter and setter for the field corresponding to the employee family name
        /// </summary>
        public string FamilyName { get => _familyName; set => _familyName = value; }

        /// <summary>
        /// Getter and setter for the field corresponding to the employee first name
        /// </summary>
        public string FirstName { get => _firstName; set => _firstName = value; }

        /// <summary>
        /// Getter and setter for the field corresponding to the employee phone
        /// </summary>
        public string Phone { get => _phone; set => _phone = value; }

        /// <summary>
        /// Getter and setter for the field corresponding to the employee mail
        /// </summary>
        public string Mail { get => _mail; set => _mail = value; }

        /// <summary>
        /// Constructor of the table employee
        /// </summary>
        /// <param name="idEmployee">idEmployee represents the primary key for the table absence</param>
        /// <param name="idDepartment">idDepartment represents the foreign key which refers to the table department</param>
        /// <param name="familyName">familyName is a field of the table employee. Its represents the employee family name</param>
        /// <param name="firstName">firstName is a field of the table employee. Its represents the employee first name</param>
        /// <param name="phone">phone is a field of the table employee. Its represents the employee phone</param>
        /// <param name="mail">mail is a field of the table employee. Its represents the employee mail</param>
        public Employee(int idEmployee, 
                        int idDepartment, 
                        string familyName, 
                        string firstName, 
                        string phone, 
                        string mail)
        {
            IdEmployee = idEmployee;
            _idDepartment = idDepartment;
            _familyName = familyName;
            _firstName = firstName;
            _phone = phone;
            _mail = mail;
        }
    }
}
