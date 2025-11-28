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

            var factory = BuildFactory();

            Application.Run(new MainForm(factory));
        }
        static ICipherFactory BuildFactory()
        {
            var services = new List<ICipherService>
            {
                new CaesarService(),
                new MonoAlphabeticService(),
                new PolyalphabeticService(),
            };

            return new CipherFactory(services);
        }
    }
}
