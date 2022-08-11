namespace BankUI.Menu
{
    partial class Tools_Options_Form
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Language = new System.Windows.Forms.Label();
            this.comboBox_SelectLanguage = new System.Windows.Forms.ComboBox();
            this.comboBox_ColorTheme = new System.Windows.Forms.ComboBox();
            this.label_ColorTheme = new System.Windows.Forms.Label();
            this.checkBox_StartUP = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button_SaveSettings = new System.Windows.Forms.Button();
            this.label_onLanguageChanged_Info = new System.Windows.Forms.Label();
            this.toolTip_onLanguageChanged = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label_onLanguageChanged_Info);
            this.groupBox1.Controls.Add(this.label_Language);
            this.groupBox1.Controls.Add(this.comboBox_SelectLanguage);
            this.groupBox1.Controls.Add(this.comboBox_ColorTheme);
            this.groupBox1.Controls.Add(this.label_ColorTheme);
            this.groupBox1.Controls.Add(this.checkBox_StartUP);
            this.groupBox1.Location = new System.Drawing.Point(239, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BankUI Experience";
            // 
            // label_Language
            // 
            this.label_Language.AutoSize = true;
            this.label_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Language.Location = new System.Drawing.Point(7, 73);
            this.label_Language.Name = "label_Language";
            this.label_Language.Size = new System.Drawing.Size(74, 16);
            this.label_Language.TabIndex = 4;
            this.label_Language.Text = "Language: ";
            this.toolTip_onLanguageChanged.SetToolTip(this.label_Language, "Restart Required");
            // 
            // comboBox_SelectLanguage
            // 
            this.comboBox_SelectLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SelectLanguage.FormattingEnabled = true;
            this.comboBox_SelectLanguage.Location = new System.Drawing.Point(117, 66);
            this.comboBox_SelectLanguage.Name = "comboBox_SelectLanguage";
            this.comboBox_SelectLanguage.Size = new System.Drawing.Size(121, 23);
            this.comboBox_SelectLanguage.TabIndex = 3;
            
            // 
            // comboBox_ColorTheme
            // 
            this.comboBox_ColorTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ColorTheme.FormattingEnabled = true;
            this.comboBox_ColorTheme.Items.AddRange(new object[] {
            "Light",
            "Dark",
            "System"});
            this.comboBox_ColorTheme.Location = new System.Drawing.Point(117, 27);
            this.comboBox_ColorTheme.Name = "comboBox_ColorTheme";
            this.comboBox_ColorTheme.Size = new System.Drawing.Size(121, 23);
            this.comboBox_ColorTheme.TabIndex = 2;
            // 
            // label_ColorTheme
            // 
            this.label_ColorTheme.AutoSize = true;
            this.label_ColorTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ColorTheme.Location = new System.Drawing.Point(7, 34);
            this.label_ColorTheme.Name = "label_ColorTheme";
            this.label_ColorTheme.Size = new System.Drawing.Size(91, 16);
            this.label_ColorTheme.TabIndex = 1;
            this.label_ColorTheme.Text = "Color Theme: ";
            // 
            // checkBox_StartUP
            // 
            this.checkBox_StartUP.AutoSize = true;
            this.checkBox_StartUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_StartUP.Location = new System.Drawing.Point(6, 114);
            this.checkBox_StartUP.Name = "checkBox_StartUP";
            this.checkBox_StartUP.Size = new System.Drawing.Size(275, 20);
            this.checkBox_StartUP.TabIndex = 0;
            this.checkBox_StartUP.Text = "Start  BankManager  on  Wndows  Start-up";
            this.checkBox_StartUP.UseVisualStyleBackColor = true;
            this.checkBox_StartUP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox_StartUP_MouseClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(233, 461);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // button_SaveSettings
            // 
            this.button_SaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveSettings.FlatAppearance.BorderSize = 0;
            this.button_SaveSettings.Location = new System.Drawing.Point(887, 418);
            this.button_SaveSettings.Name = "button_SaveSettings";
            this.button_SaveSettings.Size = new System.Drawing.Size(85, 31);
            this.button_SaveSettings.TabIndex = 2;
            this.button_SaveSettings.Text = "Save";
            this.button_SaveSettings.UseVisualStyleBackColor = true;
            this.button_SaveSettings.Click += new System.EventHandler(this.button_SaveSettings_Click);
            // 
            // label_onLanguageChanged_Info
            // 
            this.label_onLanguageChanged_Info.AutoSize = true;
            this.label_onLanguageChanged_Info.Location = new System.Drawing.Point(256, 71);
            this.label_onLanguageChanged_Info.Name = "label_onLanguageChanged_Info";
            this.label_onLanguageChanged_Info.Size = new System.Drawing.Size(0, 13);
            this.label_onLanguageChanged_Info.TabIndex = 5;
            // 
            // toolTip_onLanguageChanged
            // 
           
            // 
            // Tools_Options_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.button_SaveSettings);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Tools_Options_Form";
            this.Text = "Tools_Options_Form";
            this.Load += new System.EventHandler(this.Tools_Options_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_ColorTheme;
        private System.Windows.Forms.Label label_ColorTheme;
        private System.Windows.Forms.CheckBox checkBox_StartUP;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox comboBox_SelectLanguage;
        private System.Windows.Forms.Button button_SaveSettings;
        private System.Windows.Forms.Label label_Language;
        private System.Windows.Forms.Label label_onLanguageChanged_Info;
        private System.Windows.Forms.ToolTip toolTip_onLanguageChanged;
    }
}