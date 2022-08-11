
namespace BankUI
{
    partial class ViewCustomers_Form
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
            this.viewAllcustomersTable = new System.Windows.Forms.DataGridView();
            this.Customer_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinedOnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SavingsBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_RefreshView = new System.Windows.Forms.Button();
            this.button_ExitViewAllCustomers = new System.Windows.Forms.Button();
            this.textBox_searchSubstring = new System.Windows.Forms.TextBox();
            this.label_SearchOptions = new System.Windows.Forms.Label();
            this.radioButton_LoadEntireDatabase = new System.Windows.Forms.RadioButton();
            this.radioButton_searchByFirstName = new System.Windows.Forms.RadioButton();
            this.radioButton_searchByLastName = new System.Windows.Forms.RadioButton();
            this.radioButton_SearchByEmail = new System.Windows.Forms.RadioButton();
            this.button_DownloadDatabase = new System.Windows.Forms.Button();
            this.label_NumOfRows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllcustomersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAllcustomersTable
            // 
            this.viewAllcustomersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAllcustomersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_Id,
            this.Firstname,
            this.Lastname,
            this.Email,
            this.JoinedOnDate,
            this.CurrentBalance,
            this.SavingsBalance});
            this.viewAllcustomersTable.Location = new System.Drawing.Point(11, 92);
            this.viewAllcustomersTable.Margin = new System.Windows.Forms.Padding(2);
            this.viewAllcustomersTable.Name = "viewAllcustomersTable";
            this.viewAllcustomersTable.Size = new System.Drawing.Size(691, 397);
            this.viewAllcustomersTable.TabIndex = 0;
            // 
            // Customer_Id
            // 
            this.Customer_Id.Frozen = true;
            this.Customer_Id.HeaderText = "Id";
            this.Customer_Id.Name = "Customer_Id";
            this.Customer_Id.ReadOnly = true;
            this.Customer_Id.Width = 50;
            // 
            // Firstname
            // 
            this.Firstname.Frozen = true;
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.Frozen = true;
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.Frozen = true;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // JoinedOnDate
            // 
            this.JoinedOnDate.Frozen = true;
            this.JoinedOnDate.HeaderText = "Joined on Date";
            this.JoinedOnDate.Name = "JoinedOnDate";
            this.JoinedOnDate.ReadOnly = true;
            // 
            // CurrentBalance
            // 
            this.CurrentBalance.Frozen = true;
            this.CurrentBalance.HeaderText = "Current Balance";
            this.CurrentBalance.Name = "CurrentBalance";
            this.CurrentBalance.ReadOnly = true;
            // 
            // SavingsBalance
            // 
            this.SavingsBalance.Frozen = true;
            this.SavingsBalance.HeaderText = "Savings Balance";
            this.SavingsBalance.Name = "SavingsBalance";
            this.SavingsBalance.ReadOnly = true;
            // 
            // customerInfoBindingSource
            // 
            this.customerInfoBindingSource.DataSource = typeof(BankUI.BankCustomers.CustomerInfo);
            // 
            // button_RefreshView
            // 
            this.button_RefreshView.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RefreshView.Location = new System.Drawing.Point(442, 497);
            this.button_RefreshView.Margin = new System.Windows.Forms.Padding(0);
            this.button_RefreshView.Name = "button_RefreshView";
            this.button_RefreshView.Size = new System.Drawing.Size(130, 30);
            this.button_RefreshView.TabIndex = 1;
            this.button_RefreshView.Text = "Refresh";
            this.button_RefreshView.UseVisualStyleBackColor = true;
            this.button_RefreshView.Click += new System.EventHandler(this.button_RefreshView_Click);
            // 
            // button_ExitViewAllCustomers
            // 
            this.button_ExitViewAllCustomers.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExitViewAllCustomers.Location = new System.Drawing.Point(572, 497);
            this.button_ExitViewAllCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.button_ExitViewAllCustomers.Name = "button_ExitViewAllCustomers";
            this.button_ExitViewAllCustomers.Size = new System.Drawing.Size(130, 30);
            this.button_ExitViewAllCustomers.TabIndex = 2;
            this.button_ExitViewAllCustomers.Text = "Exit";
            this.button_ExitViewAllCustomers.UseVisualStyleBackColor = true;
            this.button_ExitViewAllCustomers.Click += new System.EventHandler(this.button_ExitViewAllCustomers_Click);
            // 
            // textBox_searchSubstring
            // 
            this.textBox_searchSubstring.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_searchSubstring.Enabled = false;
            this.textBox_searchSubstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searchSubstring.Location = new System.Drawing.Point(207, 60);
            this.textBox_searchSubstring.Name = "textBox_searchSubstring";
            this.textBox_searchSubstring.Size = new System.Drawing.Size(379, 24);
            this.textBox_searchSubstring.TabIndex = 3;
            // 
            // label_SearchOptions
            // 
            this.label_SearchOptions.AutoSize = true;
            this.label_SearchOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SearchOptions.Location = new System.Drawing.Point(12, 9);
            this.label_SearchOptions.Name = "label_SearchOptions";
            this.label_SearchOptions.Size = new System.Drawing.Size(115, 18);
            this.label_SearchOptions.TabIndex = 4;
            this.label_SearchOptions.Text = "Search Options:";
            // 
            // radioButton_LoadEntireDatabase
            // 
            this.radioButton_LoadEntireDatabase.AutoSize = true;
            this.radioButton_LoadEntireDatabase.Checked = true;
            this.radioButton_LoadEntireDatabase.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton_LoadEntireDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_LoadEntireDatabase.Location = new System.Drawing.Point(45, 35);
            this.radioButton_LoadEntireDatabase.Name = "radioButton_LoadEntireDatabase";
            this.radioButton_LoadEntireDatabase.Size = new System.Drawing.Size(150, 20);
            this.radioButton_LoadEntireDatabase.TabIndex = 5;
            this.radioButton_LoadEntireDatabase.TabStop = true;
            this.radioButton_LoadEntireDatabase.Text = "Load Entire Database";
            this.radioButton_LoadEntireDatabase.UseVisualStyleBackColor = true;
            this.radioButton_LoadEntireDatabase.CheckedChanged += new System.EventHandler(this.radioButton_LoadEntireDatabase_CheckedChanged);
            // 
            // radioButton_searchByFirstName
            // 
            this.radioButton_searchByFirstName.AutoSize = true;
            this.radioButton_searchByFirstName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton_searchByFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_searchByFirstName.Location = new System.Drawing.Point(207, 35);
            this.radioButton_searchByFirstName.Name = "radioButton_searchByFirstName";
            this.radioButton_searchByFirstName.Size = new System.Drawing.Size(122, 20);
            this.radioButton_searchByFirstName.TabIndex = 6;
            this.radioButton_searchByFirstName.Text = "Search by Name";
            this.radioButton_searchByFirstName.UseVisualStyleBackColor = true;
            this.radioButton_searchByFirstName.CheckedChanged += new System.EventHandler(this.radioButton_searchByFirstName_CheckedChanged);
            // 
            // radioButton_searchByLastName
            // 
            this.radioButton_searchByLastName.AutoSize = true;
            this.radioButton_searchByLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButton_searchByLastName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton_searchByLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_searchByLastName.Location = new System.Drawing.Point(329, 35);
            this.radioButton_searchByLastName.Name = "radioButton_searchByLastName";
            this.radioButton_searchByLastName.Size = new System.Drawing.Size(143, 20);
            this.radioButton_searchByLastName.TabIndex = 7;
            this.radioButton_searchByLastName.Text = "Search by Lastname";
            this.radioButton_searchByLastName.UseVisualStyleBackColor = true;
            this.radioButton_searchByLastName.CheckedChanged += new System.EventHandler(this.radioButton_searchByLastName_CheckedChanged);
            // 
            // radioButton_SearchByEmail
            // 
            this.radioButton_SearchByEmail.AutoSize = true;
            this.radioButton_SearchByEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton_SearchByEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_SearchByEmail.Location = new System.Drawing.Point(472, 35);
            this.radioButton_SearchByEmail.Name = "radioButton_SearchByEmail";
            this.radioButton_SearchByEmail.Size = new System.Drawing.Size(120, 20);
            this.radioButton_SearchByEmail.TabIndex = 8;
            this.radioButton_SearchByEmail.Text = "Search by Email";
            this.radioButton_SearchByEmail.UseVisualStyleBackColor = true;
            this.radioButton_SearchByEmail.CheckedChanged += new System.EventHandler(this.radioButton_SearchByEmail_CheckedChanged);
            // 
            // button_DownloadDatabase
            // 
            this.button_DownloadDatabase.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DownloadDatabase.Location = new System.Drawing.Point(45, 61);
            this.button_DownloadDatabase.Name = "button_DownloadDatabase";
            this.button_DownloadDatabase.Size = new System.Drawing.Size(130, 24);
            this.button_DownloadDatabase.TabIndex = 9;
            this.button_DownloadDatabase.Text = "Load";
            this.button_DownloadDatabase.UseVisualStyleBackColor = true;
            this.button_DownloadDatabase.Click += new System.EventHandler(this.button_DownloadDatabase_Click);
            // 
            // label_NumOfRows
            // 
            this.label_NumOfRows.AutoSize = true;
            this.label_NumOfRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NumOfRows.Location = new System.Drawing.Point(8, 497);
            this.label_NumOfRows.Name = "label_NumOfRows";
            this.label_NumOfRows.Size = new System.Drawing.Size(71, 15);
            this.label_NumOfRows.TabIndex = 10;
            this.label_NumOfRows.Text = "Total Rows:";
            // 
            // ViewAllCustomers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 531);
            this.Controls.Add(this.label_NumOfRows);
            this.Controls.Add(this.button_DownloadDatabase);
            this.Controls.Add(this.radioButton_SearchByEmail);
            this.Controls.Add(this.radioButton_searchByLastName);
            this.Controls.Add(this.radioButton_searchByFirstName);
            this.Controls.Add(this.radioButton_LoadEntireDatabase);
            this.Controls.Add(this.label_SearchOptions);
            this.Controls.Add(this.textBox_searchSubstring);
            this.Controls.Add(this.button_ExitViewAllCustomers);
            this.Controls.Add(this.button_RefreshView);
            this.Controls.Add(this.viewAllcustomersTable);
            this.MaximumSize = new System.Drawing.Size(730, 570);
            this.MinimumSize = new System.Drawing.Size(730, 570);
            this.Name = "ViewAllCustomers_Form";
            this.Text = "ViewAllCustomers_Form";
            this.Load += new System.EventHandler(this.ViewAllCustomers_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAllcustomersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewAllcustomersTable;
        private System.Windows.Forms.BindingSource customerInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinedOnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn SavingsBalance;
        private System.Windows.Forms.Button button_RefreshView;
        private System.Windows.Forms.Button button_ExitViewAllCustomers;
        private System.Windows.Forms.TextBox textBox_searchSubstring;
        private System.Windows.Forms.Label label_SearchOptions;
        private System.Windows.Forms.RadioButton radioButton_LoadEntireDatabase;
        private System.Windows.Forms.RadioButton radioButton_searchByFirstName;
        private System.Windows.Forms.RadioButton radioButton_searchByLastName;
        private System.Windows.Forms.RadioButton radioButton_SearchByEmail;
        private System.Windows.Forms.Button button_DownloadDatabase;
        private System.Windows.Forms.Label label_NumOfRows;
    }
}