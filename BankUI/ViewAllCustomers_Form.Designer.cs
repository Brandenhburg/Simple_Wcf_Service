﻿
namespace BankUI
{
    partial class ViewAllCustomers_Form
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
            this.customerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Customer_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinedOnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SavingsBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.viewAllcustomersTable.Location = new System.Drawing.Point(12, 3);
            this.viewAllcustomersTable.Name = "viewAllcustomersTable";
            this.viewAllcustomersTable.Size = new System.Drawing.Size(691, 397);
            this.viewAllcustomersTable.TabIndex = 0;
            // 
            // customerInfoBindingSource
            // 
            this.customerInfoBindingSource.DataSource = typeof(BankUI.BankCustomers.CustomerInfo);
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
            // ViewAllCustomers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 406);
            this.Controls.Add(this.viewAllcustomersTable);
            this.Name = "ViewAllCustomers_Form";
            this.Text = "ViewAllCustomers_Form";
            ((System.ComponentModel.ISupportInitialize)(this.viewAllcustomersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}