using KCDesktop.ui.members;
using KCDesktop.ui.payment;
using System;
using System.Windows.Forms;


namespace KCDesktop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmHome());
        }
    }
}
