using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediatek86.View;
using Mediatek86.Control;

namespace Mediatek86
{
    static class Program
    {
        /// <summary>
        /// Main entry for the app
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new ControlMyApp();
        }
    }
}
