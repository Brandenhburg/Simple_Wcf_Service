using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankUI.Security;

namespace BankUI.Launcher
{
    public partial class SignUp_Form : Form
    {
        Point mouseDiffPosition;
        bool mouseDown = false;
        Authentication_Form authentication_Form;

        public SignUp_Form(Authentication_Form authentication_Form)
        {
            StartPosition = FormStartPosition.Manual;
            Location = authentication_Form.Location;

            this.authentication_Form = authentication_Form;
            this.authentication_Form.Visible = false;

            InitializeComponent();
        }



        private async void button_Submit_Click(object sender, EventArgs e)
        {
            
            if (CheckForEmptiness())
                return;
            
            if (!PasswordMatching())
                return;
            
            
            DisableFormControls();
            
            
            bool isNewEmployeeCreated = await authentication_Form.securityService_client
                                               .SignUpAsync(textBox_Username.Text, textBox_Email.Text, textBox_ConfirmPassword.Text);
            
            if (isNewEmployeeCreated)
            {
                label_Error.ForeColor = Color.Green;
                label_Error.Text = "Confirmed";
                await Task.Delay(1000);
                Close();
            }
            else
            {
            
                textBox_Password.Text = String.Empty;
                textBox_Password.BackColor = SystemColors.Window;

                textBox_ConfirmPassword.Text = String.Empty;
                textBox_ConfirmPassword.BackColor = SystemColors.Window;

                label_Error.ForeColor = Color.Red;
                label_Error.Text = "Unavailable username or password";

                EnableFormControls();
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            authentication_Form.Location = this.Location;
            authentication_Form.Visible = true;
        }
        private void button_backToLogin_Click(object sender, EventArgs e) => Close();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Application.Exit();



        #region [MouseEvents]
        private void Register_Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDiffPosition.X = Cursor.Position.X - Left;
            mouseDiffPosition.Y = Cursor.Position.Y - Top;
            mouseDown = true;
        }
        private void Register_Form_MouseUp(object sender, MouseEventArgs e) => mouseDown = false;
        private void Register_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Left = Cursor.Position.X - mouseDiffPosition.X;
                Top = Cursor.Position.Y - mouseDiffPosition.Y;
            }
        }
        #endregion



        #region [Handlers]
        private bool PasswordMatching()
        {
            if (textBox_Password.Text != textBox_ConfirmPassword.Text)
            {
                textBox_Password.BackColor = Color.LightGoldenrodYellow;
                textBox_ConfirmPassword.BackColor = Color.LightGoldenrodYellow;

                label_Error.ForeColor = Color.Red;
                label_Error.Text = "*Passwords do not match. Please try again.";
                return false ;
            }

            return true;
        }
        private bool CheckForEmptiness()
        {
            Dictionary<Label, TextBox> dictionary = new Dictionary<Label, TextBox>();
            dictionary.Add(label_Username, textBox_Username);
            dictionary.Add(label_Email, textBox_Email);
            dictionary.Add(label_Password, textBox_Password);
            dictionary.Add(label_ConfirmPassword, textBox_ConfirmPassword);

            bool isEmpty = false;
            foreach (var item in dictionary)
            {
                if (item.Value.Text == string.Empty)
                {
                    item.Key.ForeColor = Color.Red;
                    isEmpty = true;
                }
                else
                    item.Key.ForeColor = Color.Black;
            }

            return isEmpty;
        }
        #endregion



        #region [Manage Form Controls]
        private void EnableFormControls()
        {
            textBox_Username.Enabled = true;
            textBox_Email.Enabled = true;
            textBox_Password.Enabled = true;
            textBox_ConfirmPassword.Enabled = true;

            button_Submit.Enabled = true;
            button_backToLogin.Enabled = true;
            linkLabel_Exit.Enabled = true;
        }
        private void DisableFormControls()
        {
            textBox_Username.Enabled = false;
            textBox_Email.Enabled = false;
            textBox_Password.Enabled = false;
            textBox_ConfirmPassword.Enabled = false;

            button_Submit.Enabled = false;
            button_backToLogin.Enabled = false;
            linkLabel_Exit.Enabled = false;
        }
        #endregion
    }
}
