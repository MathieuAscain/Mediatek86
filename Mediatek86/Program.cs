using System;
using System.Windows.Forms;
using Mediatek86.Control;

namespace Mediatek86
{
    /// <summary>
    /// Class of the program
    /// </summary>
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
