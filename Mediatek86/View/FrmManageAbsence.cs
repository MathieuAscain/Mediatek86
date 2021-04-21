using System.Windows.Forms;
using Mediatek86.Control;

namespace Mediatek86.View
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmManageAbsence : Form
    {
        private readonly ControlMyApp _controlMyApp;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controlMyApp"></param>
        public FrmManageAbsence(ControlMyApp controlMyApp)
        {
            InitializeComponent();
            _controlMyApp = controlMyApp;
        }
    }
}
