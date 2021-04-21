using System;
using Mediatek86.dal;
using Mediatek86.View;

namespace Mediatek86.Control
{
    /// <summary>
    /// Class which control the instantiation of the authentification form
    /// </summary>
    public class ControlMyApp
    {
        private readonly FrmAuthentification FrmAuthentification;

        /// <summary>
        /// Contructor which will create an instance of the authentification form
        /// </summary>
        public ControlMyApp()
        {
            FrmAuthentification = new FrmAuthentification(this);
            FrmAuthentification.ShowDialog();

        }

        /// <summary>
        /// Control that the input given by the manager fits with the input stored in the database
        /// </summary>
        /// <param name="login">user login</param>
        /// <param name="password">user password</param>
        /// <returns>true if the authentification is successfull</returns>
        public Boolean ControlAuthentification(string login, string password)
        {
            if (AccessDataBase.ControlAuthentification(login, password))
            {
                FrmAuthentification.Hide();
                (new FrmEmployee(this)).ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
