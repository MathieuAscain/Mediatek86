using Mediatek86.Connexion;
using Mediatek86.Model;
using System;
using System.Collections.Generic;


namespace Mediatek86.dal
{
    /// <summary>
    /// Class to access to the database
    /// and to generate the cursor with the request passed by parameter
    /// </summary>
    public class AccessDataBase
    {
        private static readonly string connexionString = "server=localhost;user id=gestionpersonnel;password=mathieu;database=gestionpersonnel;SslMode=none";

        /// <summary>
        /// Check if the input given by the manager fits with the data stored in the database
        /// and create the cursor with the parameters request
        /// </summary>
        /// <param name="login">login given by the user</param>
        /// <param name="password">password given by the user</param>
        /// <returns>true if the request return at least a tuple</returns>
        public static Boolean ControlAuthentification(string login, string password)
        {
            string req = "select * from responsable ";
            req += "where login=@login and pwd=SHA2(@pwd, 256);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@login", login },
                { "@pwd", password }
            };
            ConnexionDataBase curs = ConnexionDataBase.GetInstance(connexionString);
            curs.ReqSelect(req, parameters);
            if (curs.Read())
            {
                curs.Close();
                return true;
            }
            else
            {
                curs.Close();
                return false;
            }
        }

        /// <summary>
        /// Get and return the employee from the database
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public static List<Employee> GetTheEmployees()
        {
            List<Employee> theEmployee = new List<Employee>();
            string req = "SELECT p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice, s.nom as service ";
            req += "from personnel p join service s on (p.idservice = s.idservice) ";
            req += "order by nom, prenom;";
            ConnexionDataBase curs = ConnexionDataBase.GetInstance(connexionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                
                Employee employee = new Employee((int)curs.Field("idpersonnel"), (string)curs.Field("nom"), (string)curs.Field("prenom"), (string)curs.Field("tel"), (string)curs.Field("mail"), (int)curs.Field("idservice"), (string)curs.Field("service"));
                theEmployee.Add(employee);
            }
            curs.Close();
            return theEmployee;
        }


            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static List<Department> GetTheDepartments()
        {
            List<Department> theDepartments = new List<Department>();
            string req = "select * from service order by nom;";
            ConnexionDataBase curs = ConnexionDataBase.GetInstance(connexionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Department department = new Department((int)curs.Field("idservice"), (string)curs.Field("nom"));
                theDepartments.Add(department);
            }
            curs.Close();
            return theDepartments;
        }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="employee"></param>
            public static void RemoveEmployeeFromAbsence(Employee employee)
        {
            string req = "delete from absence where idpersonnel = @idpersonnelAbsence ";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@idpersonnelAbsence", employee.IdEmployee}
            };
            ConnexionDataBase connexion = ConnexionDataBase.GetInstance(connexionString);
            connexion.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public static void RemoveEmployeeFromEmployee(Employee employee)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnelPersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@idpersonnelPersonnel", employee.IdEmployee}
            };
            ConnexionDataBase connexion = ConnexionDataBase.GetInstance(connexionString);
            connexion.ReqUpdate(req, parameters);
        }


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
            ConnexionDataBase connexion = ConnexionDataBase.GetInstance(connexionString);
            connexion.ReqUpdate(req, parameters);
        }

       public static void AddModifiedEmployee(Employee employee)
        {
            string req = "insert into personnel(nom, prenom, tel, mail, idservice) ";
            req += "values (@nom, @prenom, @tel, @mail, @idservice);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@nom", employee.FamilyName },
                {"@prenom", employee.FirstName },
                {"@tel", employee.Phone },
                {"@mail", employee.Mail },
                {"@idservice", employee.IdDepartment }
            };
            ConnexionDataBase connexion = ConnexionDataBase.GetInstance(connexionString);
            connexion.ReqUpdate(req, parameters);
        }


        
        public static List<Absence> GetTheAbsences(Employee employee)
        {
            List<Absence> theAbsences = new List<Absence>();
            string req = "select a.idpersonnel as idpersonnel, a.datedebut as datedebut, m.idmotif as idmotif, a.datefin as datefin, m.libelle as libelle ";
            req += "from absence a join motif m using (idmotif) ";
            req += "where a.idpersonnel = @idpersonnel";
            Console.WriteLine(employee.IdEmployee);
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@idpersonnel", employee.IdEmployee / 2}
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

        public static List<Reason> GetTheReasons()
        {
            List<Reason> theReasons = new List<Reason>();
            string req = "select * from motif order by libelle;";
            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqSelect(req, null);
            while (cursor.Read())
            {
                Reason reason = new Reason((int)cursor.Field("idmotif"), (string)cursor.Field("libelle"));
                theReasons.Add(reason);
            }
            cursor.Close();
            return theReasons;
        }
        
    }
}

