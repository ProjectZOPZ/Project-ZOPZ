using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ZOPZZ
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (IsApplicationAlreadyRunning())
            {
                Mess.Show("Project ZOPZ", "The Application Is Already Running");
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new login());
            }
        }

        static bool IsApplicationAlreadyRunning()
        {
            return Process.GetProcesses().Count(p => p.ProcessName.Contains(Assembly.GetExecutingAssembly().FullName.Split(',')[0]) && !p.Modules[0].FileName.Contains("vshost")) > 1;
        }
    }
}
