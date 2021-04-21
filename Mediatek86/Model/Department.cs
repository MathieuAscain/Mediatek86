
namespace Mediatek86.Model
{
    /// <summary>
    /// To get access and modify the requested data stored in the table Department
    /// The class is defined as abstract because no additional data shall be created
    /// </summary>
    abstract class Department
    {
        /// <summary>
        /// Only a getter as this field is the primary key from the table department
        /// </summary>
        public int IdDepartment { get; }

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
    }
}
