using System;
using System.Windows.Forms;

namespace ShutdownEnhanced
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// En cas de problème : contacter Ayaz
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
