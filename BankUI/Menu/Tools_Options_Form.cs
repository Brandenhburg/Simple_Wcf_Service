using System;
using System.Windows.Forms;

using BankUI.Properties;
using Microsoft.Win32;

namespace BankUI.Menu
{
    public partial class Tools_Options_Form : Form
    {

        static Tools_Options_Form instance;
        private Tools_Options_Form()
        {
            InitializeComponent();
        }


        public static Tools_Options_Form GetForm()
        {
            if (instance == null)
                instance = new Tools_Options_Form();

            return instance;
        }

        private void Tools_Options_Form_Load(object sender, EventArgs e)
        {
            if (Settings.Default.StartUP == true)
                checkBox_StartUP.CheckState = CheckState.Checked;
            else
                checkBox_StartUP.CheckState = CheckState.Unchecked;
        }

        private void checkBox_StartUP_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox_StartUP.CheckState == CheckState.Checked)
            {
                Settings.Default.StartUP = true;

                
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                //key.SetValue("BankManager", $@"D:\Simple WCF Service\BankUI\bin\Debug\BankUI.exe");
                key.SetValue("BankManager", $@"{Application.StartupPath}\BankUI.exe");

                Settings.Default.Save();
            }
            else
            {
                Settings.Default.StartUP = false;

                Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue("BankManager");

                Settings.Default.Save();
            }
        }
    }
}
