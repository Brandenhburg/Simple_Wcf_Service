using BankUI.Properties;
using System;
using System.Diagnostics;
using System.Globalization;
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

        [STAThread]
        static void Main(string[] args)
        {
            bool tryCreateNewApp;
            instance = new Mutex(true, appName, out tryCreateNewApp);

            if (tryCreateNewApp)
            {            
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo($"{Settings.Default.CurrentCulture}");
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo($"{Settings.Default.CurrentCulture}");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main_Form());                  
            }
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo($"{Settings.Default.CurrentCulture}");
            //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo($"{Settings.Default.CurrentCulture}");
            //
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main_Form());
        } 
    }
}
