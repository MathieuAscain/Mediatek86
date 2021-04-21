using System.Windows.Forms;
using Mediatek86.Control;

namespace Mediatek86.View
{
    /// <summary>
    /// Form for the 
    /// </summary>
    public partial class FrmEmployee : Form
    {
        private ControlMyApp controlMyApp;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controlMyApp"></param>
        public FrmEmployee(ControlMyApp controlMyApp)
        {
            InitializeComponent();
            this.controlMyApp = controlMyApp;
        }
    }

    
}
