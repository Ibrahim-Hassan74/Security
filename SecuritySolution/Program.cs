using Security.Service;
using Security.ServiceContract;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Security
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

            var mainForm = new MainForm();
            //var passwordChecker = new PasswordCheckerForm();
            //var sqlInjector = new SqlInjectionForm();
            Application.Run(mainForm);
        }
    }
}
