using System;
using System.Drawing;
using System.Windows.Forms;
using Mediatek86.Control;

/// <summary>
/// View in the MVC conception for the Authentification Form
/// </summary>
namespace Mediatek86.View
{
    /// <summary>
    /// Form of the authentification
    /// First graphic interface for the login and check password stored in the database
    /// </summary>
    public partial class FrmAuthentification : Form
    {

        private readonly ControlMyApp controlMyApp;

        /// <summary>
        /// Constructor of the FrmAuthentification
        /// Instance of the class Control saved has a field
        /// </summary>
        /// <param name="controlMyApp">instance of the class Control</param>
        public FrmAuthentification(ControlMyApp controlMyApp)
        {
            InitializeComponent();
            this.controlMyApp = controlMyApp;
            BtnConnexion.BackColor = Color.Aquamarine;

        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxLogin.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
            {
                BtnConnexion.BackColor = Color.Coral;
                MessageBox.Show("All the fields shall be filled", "Information");

            }
            else if (!controlMyApp.ControlAuthentification(textBoxLogin.Text, textBoxPassword.Text))
            {
                    BtnConnexion.BackColor = Color.Coral;
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    textBoxLogin.Focus();
                    MessageBox.Show("Wrong authentification or you are not admin", "Alert");
                    BtnConnexion.BackColor = Color.Aquamarine;
            }
        }
    }
}
