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
            this.TypeBox.Location = new System.Drawing.Point(6, 243);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(2);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(102, 21);
            this.TypeBox.TabIndex = 46;
            this.TypeBox.Text = "Account Type";
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(68, 145);
            this.CityBox.Margin = new System.Windows.Forms.Padding(2);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(78, 20);
            this.CityBox.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "City:";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(6, 224);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(144, 20);
            this.PhoneBox.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 210);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Phone Number";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(6, 326);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(70, 29);
            this.CancelButton.TabIndex = 43;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(6, 184);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(142, 20);
            this.EmailBox.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Email Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Postal Code:";
            // 
            // PostalBox
            // 
            this.PostalBox.Location = new System.Drawing.Point(147, 145);
            this.PostalBox.Margin = new System.Windows.Forms.Padding(2);
            this.PostalBox.Name = "PostalBox";
            this.PostalBox.Size = new System.Drawing.Size(78, 20);
            this.PostalBox.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Province: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Street Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "House Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Suite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "First Name:";
            // 
            // ProvinceBox
            // 
            this.ProvinceBox.Location = new System.Drawing.Point(6, 145);
            this.ProvinceBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProvinceBox.Name = "ProvinceBox";
            this.ProvinceBox.Size = new System.Drawing.Size(52, 20);
            this.ProvinceBox.TabIndex = 29;
            // 
            // StreetBox
            // 
            this.StreetBox.Location = new System.Drawing.Point(147, 99);
            this.StreetBox.Margin = new System.Windows.Forms.Padding(2);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(78, 20);
            this.StreetBox.TabIndex = 28;
            // 
            // HouseBox
            // 
            this.HouseBox.Location = new System.Drawing.Point(68, 99);
            this.HouseBox.Margin = new System.Windows.Forms.Padding(2);
            this.HouseBox.Name = "HouseBox";
            this.HouseBox.Size = new System.Drawing.Size(78, 20);
            this.HouseBox.TabIndex = 27;
            // 
            // SuiteBox
            // 
            this.SuiteBox.Location = new System.Drawing.Point(6, 99);
            this.SuiteBox.Margin = new System.Windows.Forms.Padding(2);
            this.SuiteBox.Name = "SuiteBox";
            this.SuiteBox.Size = new System.Drawing.Size(52, 20);
            this.SuiteBox.TabIndex = 26;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(6, 62);
            this.LastNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(140, 20);
            this.LastNameBox.TabIndex = 25;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(6, 24);
            this.FirstNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(140, 20);
            this.FirstNameBox.TabIndex = 24;
            // 
            // EditUserButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(79, 325);
            this.EditUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(69, 29);
            this.EditUserButton.TabIndex = 23;
            this.EditUserButton.Text = "Edit User";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Enabled = false;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 273);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 49;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Location = new System.Drawing.Point(6, 290);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 50;
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 362);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditCustomerForm";
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.EditCustomerForm_Load);
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
    }
}