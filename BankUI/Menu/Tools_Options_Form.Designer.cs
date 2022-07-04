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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_ColorTheme = new System.Windows.Forms.ComboBox();
            this.label_ColorTheme = new System.Windows.Forms.Label();
            this.checkBox_StartUP = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.comboBox_ColorTheme);
            this.groupBox1.Controls.Add(this.label_ColorTheme);
            this.groupBox1.Controls.Add(this.checkBox_StartUP);
            this.groupBox1.Location = new System.Drawing.Point(239, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BankUI Experience";
            // 
            // comboBox_ColorTheme
            // 
            this.comboBox_ColorTheme.FormattingEnabled = true;
            this.comboBox_ColorTheme.Items.AddRange(new object[] {
            "Light",
            "Dark",
            "System"});
            this.comboBox_ColorTheme.Location = new System.Drawing.Point(117, 27);
            this.comboBox_ColorTheme.Name = "comboBox_ColorTheme";
            this.comboBox_ColorTheme.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ColorTheme.TabIndex = 2;
            // 
            // label_ColorTheme
            // 
            this.label_ColorTheme.AutoSize = true;
            this.label_ColorTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ColorTheme.Location = new System.Drawing.Point(7, 30);
            this.label_ColorTheme.Name = "label_ColorTheme";
            this.label_ColorTheme.Size = new System.Drawing.Size(91, 16);
            this.label_ColorTheme.TabIndex = 1;
            this.label_ColorTheme.Text = "Color Theme: ";
            // 
            // checkBox_StartUP
            // 
            this.checkBox_StartUP.AutoSize = true;
            this.checkBox_StartUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_StartUP.Location = new System.Drawing.Point(6, 88);
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
            this.splitter1.Size = new System.Drawing.Size(233, 477);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // Tools_Options_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 477);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
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
    }
}