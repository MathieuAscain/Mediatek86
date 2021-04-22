
namespace Mediatek86.Model
{
    /// <summary>
    /// To get access to the data stored in the table Absence
    /// </summary>
    public class Reason
    {
        /// <summary>
        /// Only a getter as this table is not supposed to be modified
        /// </summary>
        public int IdReason { get; }

        /// <summary>
        /// Only a getter as this table is not supposed to be modified
        /// </summary>
        public string Justification { get; }

        /// <summary>
        /// Constructor of the class Absence
        /// </summary>
        /// <param name="idReason">idReason represents the primary key for the table reason</param>
        /// <param name="justification">justification is a field of the table Reason. Its represent the reason of the absence</param>
        public Reason(int idReason, string justification)
        {
            IdReason = idReason;
            Justification = justification;
        }
    }
}
