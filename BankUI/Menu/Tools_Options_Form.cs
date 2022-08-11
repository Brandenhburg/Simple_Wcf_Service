using System;
using System.Globalization;
using System.Windows.Forms;

using Microsoft.Win32;

using BankUI.Properties;


namespace BankUI.Menu
{
    public partial class Tools_Options_Form : Form
    {

        static Tools_Options_Form instance;
        private readonly Main_Form mainForm;

        public ComboBox ComboBox_SelectLanguage { get => comboBox_SelectLanguage; }

        private Tools_Options_Form(Main_Form mainForm)
        {           
            InitializeComponent();
            this.mainForm = mainForm;
        }


        public static Tools_Options_Form GetForm(Main_Form mainForm)
        {
            if (instance == null)
                instance = new Tools_Options_Form(mainForm);

            return instance;
        }

        private void Tools_Options_Form_Load(object sender, EventArgs e)
        {
            //WinAPI.AnimateWindow(Handle, 200, WinAPI.BLEND);

            comboBox_SelectLanguage.Items.AddRange(supportedLanguages());

            comboBox_SelectLanguage.Text = Settings.Default.CurrentCulture;

            if (Settings.Default.StartUP)
                checkBox_StartUP.CheckState = CheckState.Checked;
            else
                checkBox_StartUP.CheckState = CheckState.Unchecked;
        }

        private void checkBox_StartUP_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox_StartUP.CheckState == CheckState.Checked)
            {
                Settings.Default.StartUP = true;

                using (RegistryKey regeditKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {                
                    regeditKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true)
                                .SetValue("BankManager",  $@"{Application.StartupPath}\BankUI.exe");
                }              
                Settings.Default.Save();                      
            }
            else
            {
                Settings.Default.StartUP = false;

                using (RegistryKey regeditKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    regeditKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true)
                                .DeleteValue("BankManager");
                }  
                
                Settings.Default.Save();
            }
        }

        private void SaveSettings()
        {
            
        }

        private void button_SaveSettings_Click(object sender, EventArgs e)
        {

            Settings.Default.CurrentCulture = comboBox_SelectLanguage.SelectedItem.ToString();
            Settings.Default.Save();
            comboBox_SelectLanguage.Text = Settings.Default.CurrentCulture;

            mainForm.Security_ServiceClient.SignOutAsync(mainForm.signedInEmployee.Id.ToString(), mainForm.signedInEmployee.Username);

            Application.Restart();
        }


        private string[] supportedLanguages()
        {
            string[] languages = new[]
            {
                CultureInfo.GetCultureInfo("en").TwoLetterISOLanguageName,
                CultureInfo.GetCultureInfo("ru").TwoLetterISOLanguageName,
                CultureInfo.GetCultureInfo("fr").TwoLetterISOLanguageName
            };

            return languages;
        }
    }
}
