
/// <summary>
/// Model in the MVC conception for the Department
/// </summary>
namespace Mediatek86.Model
{
    /// <summary>
    /// To get access and modify the requested data stored in the table Department
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Getter and setter for the ID department
        /// </summary>
        public int IdDepartment { get; set; }

        /// <summary>
        /// Only a getter as this table is not supposed to be modified
        /// </summary>
        public string DepartmentName { get; }

        /// <summary>
        ///  Constructor of the table department
        /// </summary>
        /// <param name="idDepartment">idDepartment represents the primary key for the table department</param>
        /// <param name="departmentName">departmentName is a field of the table department. Its represents the name of the department</param>
        public Department(int idDepartment, string departmentName)
        {
            IdDepartment = idDepartment;
            DepartmentName = departmentName;
        }

        /// <summary>
        /// Define the information to be displayed (only the name)
        /// </summary>
        /// <returns>name of the department</returns>
        public override string ToString()
        {
            return DepartmentName;
        }
    }
}
