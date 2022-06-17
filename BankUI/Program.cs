using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;


namespace BankUI
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        private static Mutex instance;
        private const string appName = "Bank Service";
        static bool isAuthenticated = false;

        [STAThread]
        static void Main(string[] args)
        {

            // To run BankUI.exe without Launcher  comment section below, or start BankUi.exe from Command Promt with "true" argument
            isAuthenticated = Convert.ToBoolean(args[0]);

            if (!isAuthenticated)
                return;
            //--------------------------------------------------

            bool tryCreateNewApp;
            instance = new Mutex(true, appName, out tryCreateNewApp);

            if (tryCreateNewApp)
            {
                                                                            //Write your path--------------------------------------------
                Process.Start(new ProcessStartInfo { FileName = @"D:\Simple WCF Service\CustomerService\bin\Debug\CustomerService.exe", WindowStyle = ProcessWindowStyle.Hidden});

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main_Form(isAuthenticated));

                Process.Start(new ProcessStartInfo { FileName = "cmd", Arguments = $"/c taskkill /f /im CustomerService.exe", WindowStyle = ProcessWindowStyle.Hidden }).WaitForExit();
            }
        } 
    }
}
