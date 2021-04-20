using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediatek86.Control;

namespace Mediatek86.View
{
    public partial class FrmManageAbsence : Form
    {
        private readonly ControlMyApp controlMyApp;

        public FrmManageAbsence(ControlMyApp controlMyApp)
        {
            InitializeComponent();
            this.controlMyApp = controlMyApp;
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
