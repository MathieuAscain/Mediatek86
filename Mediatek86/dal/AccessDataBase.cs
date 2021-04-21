using Mediatek86.Connexion;
//using Mediatek.Model;
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
    }
}
