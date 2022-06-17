using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        static Mutex instance;
        const string ProcessName = "Bank Service Launcher";

        [STAThread]
        static void Main()
        {

            bool tryCreateNewApp;
            instance = new Mutex(true, ProcessName, out tryCreateNewApp);

            if (tryCreateNewApp)
            {
                                                                            //Write your path--------------------------------------------
                Process.Start(new ProcessStartInfo { FileName = @"D:\Simple Wcf Service\SecurityService_Host\bin\Debug\SecurityService_Host.exe", WindowStyle  = ProcessWindowStyle.Hidden});

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Authentication_Form());

                //TaskKill("taskkill /f /im SecurityService_Host.exe");
            }
            
        }

        static void TaskKill(string line) => Process.Start(new ProcessStartInfo { FileName = "cmd", Arguments = $"/c {line}", WindowStyle = ProcessWindowStyle.Hidden}).WaitForExit();
       
    }
}
