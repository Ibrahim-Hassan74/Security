using Microsoft.EntityFrameworkCore;
using Security.Models;
using Security.Service;
using Security.ServiceContract;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            var conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(conn);
            using (var context = new ApplicationDbContext(optionsBuilder.Options))
            {
                context.Database.EnsureCreated();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var mainForm = new MainForm(context);
                Application.Run(mainForm);
            }

        }
    }
}
