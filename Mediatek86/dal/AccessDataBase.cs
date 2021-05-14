using Mediatek86.Connexion;
using Mediatek86.Model;
using System;
using System.Collections.Generic;

/// <summary>
/// AcccessDataBase class for the SQL requests
/// </summary>
namespace Mediatek86.dal
{
    /// <summary>
    /// Class which defines the SQL request to interrogate the database
    /// </summary>
    public static class AccessDataBase
    {
        private static readonly string connexionString = "server=localhost;user id=gestionpersonnel;password=mathieu;database=gestionpersonnel;SslMode=none";

        /// <summary>
        /// Method to control the authentification
        /// </summary>
        /// <param name="login">login of the connexion</param>
        /// <param name="password">password of the connexion</param>
        /// <returns>true if the connexion is open, false otherwise</returns>
        public static Boolean ControlAuthentification(string login, string password)
        {
            string req = "select * from responsable ";
            req += "where login=@login and pwd=SHA2(@pwd, 256);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@login", login },
                { "@pwd", password }
            };
            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqSelect(req, parameters);
            if (cursor.Read())
            {
                cursor.Close();
                return true;
            }
            else
            {
                cursor.Close();
                return false;
            }
        }

        /// <summary>
        /// Get the list of all employees
        /// </summary>
        /// <returns>List of employees in the database</returns>
        public static List<Employee> GetTheEmployees()
        {
            List<Employee> theEmployee = new List<Employee>();
            string req = "SELECT p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice, s.nom as service ";
            req += "from personnel p join service s on (p.idservice = s.idservice) ";
            req += "order by nom, prenom;";
            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqSelect(req, null);
            while (cursor.Read())
            {
                
                Employee employee = new Employee((int)cursor.Field("idpersonnel"), 
                                                 (string)cursor.Field("nom"), 
                                                 (string)cursor.Field("prenom"), 
                                                 (string)cursor.Field("tel"), 
                                                 (string)cursor.Field("mail"), 
                                                 (int)cursor.Field("idservice"), 
                                                 (string)cursor.Field("service"));
                theEmployee.Add(employee);
            }
            cursor.Close();
            return theEmployee;
        }

        /// <summary>
        /// Get the maximum employee ID from the employee in the database
        /// </summary>
        /// <returns>integer (maximum ID of the employee) in the table EMPLOYEE</returns>
        public static int GetMaxEmployeeID()
        {
            string req = "select max(idpersonnel) from personnel";
            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqSelect(req, null);
            int max = 0;
            if (cursor.Read())
            {
                max = (int)cursor.Field("max(idpersonnel)");
            }
            cursor.Close();
            return max;
        }

        /// <summary>
        /// Add an employee to the database
        /// </summary>
        /// <param name="employee">Employee (object) from the data selected by user</param>
        public static void AddEmployee(Employee employee)
        {
            string req = "insert into personnel(idpersonnel, idservice, nom, prenom, tel, mail) ";
            req += "values (@idpersonnel, @idservice, @nom, @prenom, @tel, @mail);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@idpersonnel", employee.IdEmployee },
                {"@nom", employee.FamilyName },
                {"@prenom", employee.FirstName },
                {"@tel", employee.Phone },
                {"@mail", employee.Mail },
                {"@idservice", employee.IdDepartment },
           
            };

            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Update employee data in the database
        /// </summary>
        /// <param name="employee">Employee (object) from the data selected by user</param>
        public static void UpdateEmployee(Employee employee)
        {
            string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice ";
            req += "where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@idpersonnel", employee.IdEmployee },
                {"@idservice", employee.IdDepartment },
                {"@nom", employee.FamilyName },
                {"@prenom", employee.FirstName },
                {"@tel", employee.Phone },
                {"@mail", employee.Mail }
            };
            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqUpdate(req, parameters);
        }


        /// <summary>
        /// Remove employee absence from the table ABSENCE
        /// </summary>
        /// <param name="employee">Employee (object) from the data selected by user</param>
        public static void RemoveEmployeeFromAbsence(Employee employee)
        {
            string req = "delete from absence where idpersonnel = @idpersonnelAbsence ";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@idpersonnelAbsence", employee.IdEmployee}
            };
            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Remove employee from the table EMPLOYEE
        /// </summary>
        /// <param name="employee">Employee (object) from the data selected by user</param>
        public static void RemoveEmployeeFromEmployee(Employee employee)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnelPersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@idpersonnelPersonnel", employee.IdEmployee}
            };
            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Get the list of departments stored in the database
        /// </summary>
        /// <returns>List of departments</returns>
        public static List<Department> GetTheDepartments()
        {
            List<Department> theDepartments = new List<Department>();
            string req = "select * from service order by nom;";
            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqSelect(req, null);
            while (cursor.Read())
            {
                Department department = new Department((int)cursor.Field("idservice"), 
                                                       (string)cursor.Field("nom"));
                theDepartments.Add(department);
            }
            cursor.Close();
            return theDepartments;
        }

        /// <summary>
        /// Get the list of absences stored in the database
        /// </summary>
        /// <param name="employee">Employee (object) from the data selected by user</param>
        /// <returns>List of absences from an employee</returns>
        public static List<Absence> GetTheAbsences(Employee employee)
        {
            List<Absence> theAbsences = new List<Absence>();
            string req = "select a.idpersonnel as idpersonnel, a.datedebut as datedebut, m.idmotif as idmotif, a.datefin as datefin, m.libelle as libelle ";
            req += "from absence a join motif m using (idmotif) ";
            req += "where a.idpersonnel = @idpersonnel ";
            req += "order by datedebut DESC";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@idpersonnel", employee.IdEmployee}
            };
            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqSelect(req, parameters);
            while (cursor.Read())
            {
                Absence absence = new Absence(employee, 
                                               (DateTime)cursor.Field("datedebut"), 
                                               (DateTime)cursor.Field("datefin"), 
                                               (int)cursor.Field("idmotif"),
                                               (string)cursor.Field("libelle")
                                               );
                theAbsences.Add(absence);
            }
            cursor.Close();
            return theAbsences;
        }

        /// <summary>
        /// Get the list of absence reasons stored in the database
        /// </summary>
        /// <returns>List of absence reasons</returns>
        public static List<Reason> GetTheReasons()
        {
            List<Reason> theReasons = new List<Reason>();
            string req = "select * from motif ";
            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqSelect(req, null);
            while (cursor.Read())
            {
                Reason reason = new Reason((int)cursor.Field("idmotif"), 
                                           (string)cursor.Field("libelle"));
                theReasons.Add(reason);
            }
            cursor.Close();
            return theReasons;
        }

        /// <summary>
        /// Add an absence to an employee
        /// </summary>
        /// <param name="employee">Employee (object) from the data selected by user</param>
        /// <param name="firstDay">first day of the absence</param>
        /// <param name="lastDay">last day of the absence</param>
        /// <param name="idReason">ID reason of the absence</param>
        public static void AddAbsence(Employee employee, DateTime firstDay, DateTime lastDay, int idReason)
        {
            string req = "insert into absence(idpersonnel, datedebut, idmotif, datefin) ";
            req += "values (@idpersonnel, @datedebut, @idmotif, @datefin) ";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@idpersonnel", employee.IdEmployee },
                {"@datedebut", firstDay },
                {"@idmotif", idReason },
                {"@datefin", lastDay }
            };

            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Update absence from an employee
        /// </summary>
        /// <param name="employee">Employee (object) from the data selected by user</param>
        /// <param name="previousDateSelected">first day, part of the composite primary key absence</param>
        /// <param name="firstDay">first day selected</param>
        /// <param name="lastDay">last day selected</param>
        /// <param name="idReason">ID reason of the absence</param>
        public static void UpdateAbsence(Employee employee,
                                         DateTime previousDateSelected,
                                         DateTime firstDay, 
                                         DateTime lastDay, 
                                         int idReason
                                         )
        {
            string req = "update absence set datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
            req += "where idpersonnel = @idpersonnel and datedebut = @datedebutAvantMAJ;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idpersonnel", employee.IdEmployee },
                { "@datedebut", firstDay },
                { "@datedebutAvantMAJ", previousDateSelected },
                { "@datefin", lastDay },
                { "@idmotif", idReason }
            };

            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Remove an absence from an employee
        /// </summary>
        /// <param name="absence">Absence (object) selected from an employee</param>
        /// <param name="employee">Employee (object) selected by a user</param>
        public static void RemoveAbsenceFromEmployee(Absence absence, Employee employee)
        {
            string req = "delete from absence ";
            req += "where idpersonnel = @idpersonnel ";
            req += "and datedebut = @datedebut";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@idpersonnel", employee.IdEmployee},
                {"@datedebut", absence.FirstDay}
            };
            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Get the last day corresponding to an absence
        /// </summary>
        /// <param name="employee">Employee (object) from the data selected by user</param>
        /// <returns>Last day corresponding to an absence</returns>
        public static DateTime AbsenceAtTheEndOfTheCalendar(Employee employee)
        {
            DateTime max = new DateTime();
            string req = "SELECT MAX(datefin) ";
            req += "FROM absence ";
            req += "WHERE idpersonnel = @idpersonnel";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@idpersonnel", employee.IdEmployee},
            };

            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqSelect(req, parameters);
            while (cursor.Read())
            {
                max = (DateTime)cursor.Field("max(datefin)");

            }
            cursor.Close();
            return max;

        }

        /// <summary>
        /// Get the first day of the next absence - timeslot in between absences
        /// </summary>
        /// <param name="employee">Employee (object) from the data selected by user</param>
        /// <param name="firstDay">first day selected by user</param>
        /// <returns>first day of the next absence</returns>
        public static DateTime LastDayIsBeforeNextAbsence(Employee employee, DateTime firstDay)
        {
            DateTime firstDayNextAbsence = new DateTime();
            string req = "SELECT MIN(datedebut) ";
            req += "FROM absence ";
            req += "WHERE idpersonnel = @idpersonnel ";
            req += "AND datedebut > @firstDayPicked";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@idpersonnel", employee.IdEmployee},
                {"@firstDayPicked", firstDay}
            };

            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqSelect(req, parameters);
            while (cursor.Read())
            {
                firstDayNextAbsence = (DateTime)cursor.Field("min(datedebut)");

            }
            cursor.Close();
            return firstDayNextAbsence;
        }

        /// <summary>
        /// Get the last day of the previous absence - timeslot in between absences
        /// </summary>
        /// <param name="employee">Employee (object) from the data selected by user</param>
        /// <param name="firstDay">first day selected by user</param>
        /// <returns>last day of the previous absence</returns>
        public static DateTime FirstDayIsAfterPreviousAbsence(Employee employee,
                                                              DateTime firstDay
                                                              )
        {
            DateTime lastDayPreviousAbsence = new DateTime();
            string req = "SELECT MAX(datefin) ";
            req += "FROM absence ";
            req += "WHERE idpersonnel = @idpersonnel ";
            req += "AND datefin < ( ";
            req += "SELECT MIN(datedebut) ";
            req += "FROM absence ";
            req += "WHERE idpersonnel = @idpersonnel ";
            req += "AND datedebut > @firstDayPicked)";


            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@idpersonnel", employee.IdEmployee},
                {"@firstDayPicked", firstDay}
            };

            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqSelect(req, parameters);
            while (cursor.Read())
            {
                lastDayPreviousAbsence = (DateTime)cursor.Field("max(datefin)");

            }
            cursor.Close();
            return lastDayPreviousAbsence;

        }

    }
}

