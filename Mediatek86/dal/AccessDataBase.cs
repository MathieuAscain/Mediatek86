using Mediatek86.Connexion;
using Mediatek86.Model;
using System;
using System.Collections.Generic;

namespace Mediatek86.dal
{
    public class AccessDataBase
    {
        private static readonly string connexionString = "server=localhost;user id=gestionpersonnel;password=mathieu;database=gestionpersonnel;SslMode=none";

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

        public static int GetMaxEmployeeID()
        {
            string req = "select max(idpersonnel) from personnel";
            ConnexionDataBase cursor = ConnexionDataBase.GetInstance(connexionString);
            cursor.ReqSelect(req, null);
            int max = 0;
            Console.WriteLine("Max id = ", max);
            if (cursor.Read())
            {
                max = (int)cursor.Field("max(idpersonnel)");
            }
            cursor.Close();
            return max;
        }

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

        public static List<Absence> GetTheAbsences(Employee employee)
        {
            List<Absence> theAbsences = new List<Absence>();
            string req = "select a.idpersonnel as idpersonnel, a.datedebut as datedebut, m.idmotif as idmotif, a.datefin as datefin, m.libelle as libelle ";
            req += "from absence a join motif m using (idmotif) ";
            req += "where a.idpersonnel = @idpersonnel ";
            req += "order by datedebut DESC";
            Console.WriteLine(employee.IdEmployee);
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
    }
}

