using System.Windows.Forms;

namespace App
{
    partial class LoginForm
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
            this.CustomerButton = new System.Windows.Forms.Button();
            this.ManagerButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerButton
            // 
            this.CustomerButton.Location = new System.Drawing.Point(104, 140);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(75, 23);
            this.CustomerButton.TabIndex = 2;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButtonClick);
            // 
            // ManagerButton
            // 
            this.ManagerButton.Location = new System.Drawing.Point(104, 169);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(75, 23);
            this.ManagerButton.TabIndex = 3;
            this.ManagerButton.Text = "Manager";
            this.ManagerButton.UseVisualStyleBackColor = true;
            this.ManagerButton.Click += new System.EventHandler(this.ManagerButtonClick);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Location = new System.Drawing.Point(104, 198);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.EmployeeButton.TabIndex = 4;
            this.EmployeeButton.Text = "Employee";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButtonClick);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(101, 40);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(104, 57);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(101, 80);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(104, 97);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(104, 124);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(29, 13);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.Text = "Error";
            this.ErrorLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.ManagerButton);
            this.Controls.Add(this.CustomerButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button ManagerButton;
        private System.Windows.Forms.Button EmployeeButton;
        private Label ErrorLabel;
    }
}