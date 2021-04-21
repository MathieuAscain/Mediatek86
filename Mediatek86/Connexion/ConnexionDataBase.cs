using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mediatek86.Connexion
{
    /// <summary>
    /// Class to manage a connexion to the database
    /// </summary>
    public class ConnexionDataBase
    {
        private static ConnexionDataBase instance = null;
      
        private readonly MySqlConnection connexion;
       
        private MySqlCommand command;
        
        private MySqlDataReader reader;

        /// <summary>
        /// Private constructor to ensure no instance will be created 
        /// except with the static method GetInstance
        /// </summary>
        /// <param name="stringConnect"></param>
        private ConnexionDataBase(string stringConnect)
        {
            try
            {
                connexion = new MySqlConnection(stringConnect);
                connexion.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }
        }

        /// <summary>
        /// Static method to return the unique instance of the connexion to the database
        /// </summary>
        /// <param name="stringConnect"></param>
        /// <returns>instance of the connexion to the data base</returns>
        public static ConnexionDataBase GetInstance(string stringConnect)
        {
            if (instance is null)
            {
                instance = new ConnexionDataBase(stringConnect);
            }
            return instance;
        }

        /// <summary>
        /// Method to execute all request except select
        /// </summary>
        /// <param name="stringQuery">query stored in a string</param>
        /// <param name="parameters">parameter of the request</param>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connexion);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Method to execute a request select
        /// </summary>
        /// <param name="stringQuery">query stored in a string</param>
        /// <param name="parameters">parameter of the request</param>
        public void ReqSelect(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connexion);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Check if the cursor can read another tuple
        /// </summary>
        /// <returns>true if the cursor can read another tuple in Field</returns>
        public bool Read()
        {
            if (reader is null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Create the field containing all the tuples corresponding to the request
        /// </summary>
        /// <param name="nameField"></param>
        /// <returns>Returns the field containing all the tuples or null</returns>
        public object Field(string nameField)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                return reader[nameField];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Close the cursor once the field is empty
        /// </summary>
        public void Close()
        {
            if (!(reader is null))
            {
                reader.Close();
            }
        }
    }
}
