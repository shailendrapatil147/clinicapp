using Clinic.Common.AppSettings;
using Clinic.Winform;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Windows.Forms;

namespace Clinic
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppConfiguration.Configuration = new ConfigurationBuilder()
                                           .SetBasePath(Path.Combine(AppContext.BaseDirectory))
                                           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                                           .Build();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuDashboard());
        }
    }
}
