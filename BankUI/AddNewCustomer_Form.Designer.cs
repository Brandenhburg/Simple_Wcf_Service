
namespace BankUI
{
    partial class AddNewCustomer_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCustomer_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.button_DepozitFunds = new System.Windows.Forms.Button();
            this.button_CreateNewCustomer = new System.Windows.Forms.Button();
            this.button_CancelCreateNewCustomer = new System.Windows.Forms.Button();
            this.myTittleButton_CloseForm = new BankUI.Customizing.MyTittleButton();
            this.myTittleButton1 = new BankUI.Customizing.MyTittleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_FirstName
            // 
            resources.ApplyResources(this.textBox_FirstName, "textBox_FirstName");
            this.textBox_FirstName.Name = "textBox_FirstName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox_LastName
            // 
            resources.ApplyResources(this.textBox_LastName, "textBox_LastName");
            this.textBox_LastName.Name = "textBox_LastName";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBox_Email
            // 
            resources.ApplyResources(this.textBox_Email, "textBox_Email");
            this.textBox_Email.Name = "textBox_Email";
            // 
            // button_DepozitFunds
            // 
            resources.ApplyResources(this.button_DepozitFunds, "button_DepozitFunds");
            this.button_DepozitFunds.Name = "button_DepozitFunds";
            this.button_DepozitFunds.UseVisualStyleBackColor = true;
            this.button_DepozitFunds.Click += new System.EventHandler(this.button_DepozitFunds_Click);
            // 
            // button_CreateNewCustomer
            // 
            resources.ApplyResources(this.button_CreateNewCustomer, "button_CreateNewCustomer");
            this.button_CreateNewCustomer.Name = "button_CreateNewCustomer";
            this.button_CreateNewCustomer.UseVisualStyleBackColor = true;
            this.button_CreateNewCustomer.Click += new System.EventHandler(this.button_CreateNewCustomer_Click);
            // 
            // button_CancelCreateNewCustomer
            // 
            resources.ApplyResources(this.button_CancelCreateNewCustomer, "button_CancelCreateNewCustomer");
            this.button_CancelCreateNewCustomer.Name = "button_CancelCreateNewCustomer";
            this.button_CancelCreateNewCustomer.UseVisualStyleBackColor = true;
            this.button_CancelCreateNewCustomer.Click += new System.EventHandler(this.button_CancelCreateNewCustomer_Click);
            // 
            // myTittleButton_CloseForm
            // 
            this.myTittleButton_CloseForm.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.myTittleButton_CloseForm, "myTittleButton_CloseForm");
            this.myTittleButton_CloseForm.Name = "myTittleButton_CloseForm";
            this.myTittleButton_CloseForm.UseVisualStyleBackColor = true;
            this.myTittleButton_CloseForm.Click += new System.EventHandler(this.myTittleButton_CloseForm_Click);
            // 
            // myTittleButton1
            // 
            this.myTittleButton1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.myTittleButton1, "myTittleButton1");
            this.myTittleButton1.Name = "myTittleButton1";
            this.myTittleButton1.UseVisualStyleBackColor = true;
            this.myTittleButton1.Click += new System.EventHandler(this.myTittleButton1_Click);
            // 
            // AddNewCustomer_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myTittleButton1);
            this.Controls.Add(this.myTittleButton_CloseForm);
            this.Controls.Add(this.button_CancelCreateNewCustomer);
            this.Controls.Add(this.button_CreateNewCustomer);
            this.Controls.Add(this.button_DepozitFunds);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewCustomer_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Button button_DepozitFunds;
        private System.Windows.Forms.Button button_CreateNewCustomer;
        private System.Windows.Forms.Button button_CancelCreateNewCustomer;
        private Customizing.MyTittleButton myTittleButton_CloseForm;
        private Customizing.MyTittleButton myTittleButton1;
    }
}