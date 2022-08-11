namespace BankUI.Launcher
{
    partial class Authentication_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication_Form));
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_GetAccess = new System.Windows.Forms.Button();
            this.linkLabel_ReadOnlyMode = new System.Windows.Forms.LinkLabel();
            this.label_Error = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.linkLabel_ExitApp = new System.Windows.Forms.LinkLabel();
            this.button_SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            resources.ApplyResources(this.textBox_username, "textBox_username");
            this.textBox_username.Name = "textBox_username";
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBox_Password, "textBox_Password");
            this.textBox_Password.Name = "textBox_Password";
            // 
            // button_GetAccess
            // 
            this.button_GetAccess.BackColor = System.Drawing.SystemColors.Control;
            this.button_GetAccess.FlatAppearance.BorderSize = 0;
            this.button_GetAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_GetAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.button_GetAccess, "button_GetAccess");
            this.button_GetAccess.Name = "button_GetAccess";
            this.button_GetAccess.UseVisualStyleBackColor = false;
            this.button_GetAccess.Click += new System.EventHandler(this.button_GetAccess_Click);
            // 
            // linkLabel_ReadOnlyMode
            // 
            resources.ApplyResources(this.linkLabel_ReadOnlyMode, "linkLabel_ReadOnlyMode");
            this.linkLabel_ReadOnlyMode.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_ReadOnlyMode.Name = "linkLabel_ReadOnlyMode";
            this.linkLabel_ReadOnlyMode.TabStop = true;
            this.linkLabel_ReadOnlyMode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ReadOnlyMode_LinkClicked);
            // 
            // label_Error
            // 
            resources.ApplyResources(this.label_Error, "label_Error");
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Name = "label_Error";
            // 
            // label_Username
            // 
            resources.ApplyResources(this.label_Username, "label_Username");
            this.label_Username.Name = "label_Username";
            // 
            // label_Password
            // 
            resources.ApplyResources(this.label_Password, "label_Password");
            this.label_Password.Name = "label_Password";
            // 
            // linkLabel_ExitApp
            // 
            resources.ApplyResources(this.linkLabel_ExitApp, "linkLabel_ExitApp");
            this.linkLabel_ExitApp.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_ExitApp.Name = "linkLabel_ExitApp";
            this.linkLabel_ExitApp.TabStop = true;
            this.linkLabel_ExitApp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ExitApp_LinkClicked);
            // 
            // button_SignIn
            // 
            this.button_SignIn.BackColor = System.Drawing.SystemColors.Control;
            this.button_SignIn.FlatAppearance.BorderSize = 0;
            this.button_SignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_SignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.button_SignIn, "button_SignIn");
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.UseVisualStyleBackColor = false;
            this.button_SignIn.Click += new System.EventHandler(this.button_SignIn_Click);
            // 
            // Authentication_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ControlBox = false;
            this.Controls.Add(this.button_SignIn);
            this.Controls.Add(this.linkLabel_ExitApp);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.linkLabel_ReadOnlyMode);
            this.Controls.Add(this.button_GetAccess);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_username);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "Authentication_Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Authentication_Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Authentication_Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Authentication_Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Authentication_Form_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_GetAccess;
        private System.Windows.Forms.LinkLabel linkLabel_ReadOnlyMode;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.LinkLabel linkLabel_ExitApp;
        private System.Windows.Forms.Button button_SignIn;
    }
}