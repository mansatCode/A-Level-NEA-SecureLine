using System;
using System.Windows.Forms;

namespace SecureLine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initalise the database connection
            GlobalConfig.InitaliseConnection(true);

            Application.Run(new LoginWindowForm());
        }
    }
}
