using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek86.View;


namespace Mediatek86.Control
{
    
    public class ControlMyApp
    {
        private readonly FrmAuthentification frmAuthentification;

        // private readonly FrmEmployee frmEmployee;

        //private readonly FrmManageAbsence frmManageAbsence;

        public ControlMyApp()
        {
            frmAuthentification = new FrmAuthentification(this);
            frmAuthentification.ShowDialog();

            //frmEmployee = new FrmManageAbsence(this);
            //frmEmployee.ShowDialog();

            //frmManageAbsence = new FrmManageAbsence(this);
            //frmManageAbsence.ShowDialog();

        }
    }
}
