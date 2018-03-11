﻿namespace App
{
    partial class AddCustomerForm
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
            this.AddUserButton = new System.Windows.Forms.Button();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.SuiteBox = new System.Windows.Forms.TextBox();
            this.HouseBox = new System.Windows.Forms.TextBox();
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.ProvinceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PostalBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(205, 501);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(138, 56);
            this.AddUserButton.TabIndex = 0;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(64, 67);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(277, 31);
            this.FirstNameBox.TabIndex = 1;
            this.FirstNameBox.Text = "jordan";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(64, 129);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(277, 31);
            this.LastNameBox.TabIndex = 2;
            this.LastNameBox.Text = "hewko";
            // 
            // SuiteBox
            // 
            this.SuiteBox.Location = new System.Drawing.Point(66, 191);
            this.SuiteBox.Name = "SuiteBox";
            this.SuiteBox.Size = new System.Drawing.Size(100, 31);
            this.SuiteBox.TabIndex = 3;
            this.SuiteBox.Text = "1234";
            // 
            // HouseBox
            // 
            this.HouseBox.Location = new System.Drawing.Point(187, 191);
            this.HouseBox.Name = "HouseBox";
            this.HouseBox.Size = new System.Drawing.Size(100, 31);
            this.HouseBox.TabIndex = 4;
            this.HouseBox.Text = "4567";
            // 
            // StreetBox
            // 
            this.StreetBox.Location = new System.Drawing.Point(66, 265);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(100, 31);
            this.StreetBox.TabIndex = 5;
            this.StreetBox.Text = "Jasper Ave";
            // 
            // ProvinceBox
            // 
            this.ProvinceBox.Location = new System.Drawing.Point(66, 327);
            this.ProvinceBox.Name = "ProvinceBox";
            this.ProvinceBox.Size = new System.Drawing.Size(100, 31);
            this.ProvinceBox.TabIndex = 6;
            this.ProvinceBox.Text = "Ab";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Suite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "House Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Street Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 573);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Note: * indicates mandatory fields";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Province: ";
            // 
            // PostalBox
            // 
            this.PostalBox.Location = new System.Drawing.Point(335, 327);
            this.PostalBox.Name = "PostalBox";
            this.PostalBox.Size = new System.Drawing.Size(128, 31);
            this.PostalBox.TabIndex = 8;
            this.PostalBox.Text = "t5t5t5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Postal Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email Address";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(64, 389);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(279, 31);
            this.EmailBox.TabIndex = 9;
            this.EmailBox.Text = "jordan@cool.dude";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(59, 501);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 55);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Phone Number";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(59, 464);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(284, 31);
            this.PhoneBox.TabIndex = 10;
            this.PhoneBox.Text = "7804234567";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "City:";
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(192, 326);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(100, 31);
            this.CityBox.TabIndex = 7;
            this.CityBox.Text = "edmonton";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 619);
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
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.AddUserButton);
            this.Name = "AddCustomerForm";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox SuiteBox;
        private System.Windows.Forms.TextBox HouseBox;
        private System.Windows.Forms.TextBox StreetBox;
        private System.Windows.Forms.TextBox ProvinceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PostalBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CityBox;
    }
}