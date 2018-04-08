namespace App
{
    partial class EditCustomerForm
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
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PostalBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProvinceBox = new System.Windows.Forms.TextBox();
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.HouseBox = new System.Windows.Forms.TextBox();
            this.SuiteBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EditCustInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Limited",
            "Bronze",
            "Silver",
            "Gold",
            "Disabled"});
            this.TypeBox.Location = new System.Drawing.Point(12, 467);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(200, 33);
            this.TypeBox.TabIndex = 46;
            this.TypeBox.Text = "Account Type";
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(136, 279);
            this.CityBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(152, 31);
            this.CityBox.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 238);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 25);
            this.label11.TabIndex = 45;
            this.label11.Text = "City:";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(12, 431);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(284, 31);
            this.PhoneBox.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 404);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 25);
            this.label10.TabIndex = 44;
            this.label10.Text = "Phone Number";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 627);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 56);
            this.CancelButton.TabIndex = 43;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(12, 354);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(280, 31);
            this.EmailBox.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 327);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 25);
            this.label9.TabIndex = 42;
            this.label9.Text = "Email Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 238);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Postal Code:";
            // 
            // PostalBox
            // 
            this.PostalBox.Location = new System.Drawing.Point(294, 279);
            this.PostalBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PostalBox.Name = "PostalBox";
            this.PostalBox.Size = new System.Drawing.Size(152, 31);
            this.PostalBox.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Province: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Street Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "House Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Suite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "First Name:";
            // 
            // ProvinceBox
            // 
            this.ProvinceBox.Location = new System.Drawing.Point(12, 279);
            this.ProvinceBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProvinceBox.Name = "ProvinceBox";
            this.ProvinceBox.Size = new System.Drawing.Size(100, 31);
            this.ProvinceBox.TabIndex = 29;
            // 
            // StreetBox
            // 
            this.StreetBox.Location = new System.Drawing.Point(294, 190);
            this.StreetBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(152, 31);
            this.StreetBox.TabIndex = 28;
            // 
            // HouseBox
            // 
            this.HouseBox.Location = new System.Drawing.Point(136, 190);
            this.HouseBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HouseBox.Name = "HouseBox";
            this.HouseBox.Size = new System.Drawing.Size(152, 31);
            this.HouseBox.TabIndex = 27;
            // 
            // SuiteBox
            // 
            this.SuiteBox.Location = new System.Drawing.Point(12, 190);
            this.SuiteBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SuiteBox.Name = "SuiteBox";
            this.SuiteBox.Size = new System.Drawing.Size(100, 31);
            this.SuiteBox.TabIndex = 26;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(12, 119);
            this.LastNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(276, 31);
            this.LastNameBox.TabIndex = 25;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(12, 46);
            this.FirstNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(276, 31);
            this.FirstNameBox.TabIndex = 24;
            // 
            // EditUserButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(158, 625);
            this.EditUserButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(138, 59);
            this.EditUserButton.TabIndex = 23;
            this.EditUserButton.Text = "Edit User";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Enabled = false;
            this.PasswordLabel.Location = new System.Drawing.Point(24, 525);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(112, 25);
            this.PasswordLabel.TabIndex = 49;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 558);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(196, 31);
            this.PasswordTextBox.TabIndex = 50;
            // 
            // EditCustInfoButton
            // 
            this.EditCustInfoButton.Location = new System.Drawing.Point(160, 627);
            this.EditCustInfoButton.Name = "EditCustInfoButton";
            this.EditCustInfoButton.Size = new System.Drawing.Size(186, 57);
            this.EditCustInfoButton.TabIndex = 51;
            this.EditCustInfoButton.Text = "Edit Information";
            this.EditCustInfoButton.UseVisualStyleBackColor = true;
            this.EditCustInfoButton.Click += new System.EventHandler(this.EditCustInfoButton_Click);
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 696);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PostalBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProvinceBox);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.HouseBox);
            this.Controls.Add(this.SuiteBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.EditCustInfoButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditCustomerForm";
            this.Text = "Edit Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PostalBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProvinceBox;
        private System.Windows.Forms.TextBox StreetBox;
        private System.Windows.Forms.TextBox HouseBox;
        private System.Windows.Forms.TextBox SuiteBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button EditCustInfoButton;
    }
}