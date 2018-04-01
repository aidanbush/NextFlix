namespace App
{
    partial class FufillOrderForm
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
            this.ShippingTitleLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.StreetAddressLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ProvenceLabel = new System.Windows.Forms.Label();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MovieIDLabel = new System.Windows.Forms.Label();
            this.FufillButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShippingTitleLabel
            // 
            this.ShippingTitleLabel.AutoSize = true;
            this.ShippingTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.ShippingTitleLabel.Name = "ShippingTitleLabel";
            this.ShippingTitleLabel.Size = new System.Drawing.Size(149, 16);
            this.ShippingTitleLabel.TabIndex = 0;
            this.ShippingTitleLabel.Text = "Shipping Information";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(16, 33);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(67, 13);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Name: name";
            // 
            // StreetAddressLabel
            // 
            this.StreetAddressLabel.AutoSize = true;
            this.StreetAddressLabel.Location = new System.Drawing.Point(16, 50);
            this.StreetAddressLabel.Name = "StreetAddressLabel";
            this.StreetAddressLabel.Size = new System.Drawing.Size(119, 13);
            this.StreetAddressLabel.TabIndex = 2;
            this.StreetAddressLabel.Text = "Street Address: address";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(16, 67);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(46, 13);
            this.CityLabel.TabIndex = 3;
            this.CityLabel.Text = "City: city";
            // 
            // ProvenceLabel
            // 
            this.ProvenceLabel.AutoSize = true;
            this.ProvenceLabel.Location = new System.Drawing.Point(16, 84);
            this.ProvenceLabel.Name = "ProvenceLabel";
            this.ProvenceLabel.Size = new System.Drawing.Size(73, 13);
            this.ProvenceLabel.TabIndex = 4;
            this.ProvenceLabel.Text = "Provence: PV";
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(16, 101);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(94, 13);
            this.PostalCodeLabel.TabIndex = 5;
            this.PostalCodeLabel.Text = "Postal Code: code";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(16, 118);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(119, 13);
            this.PhoneLabel.TabIndex = 6;
            this.PhoneLabel.Text = "Phone Number: number";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(16, 135);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(62, 13);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email: email";
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieLabel.Location = new System.Drawing.Point(13, 162);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(50, 16);
            this.MovieLabel.TabIndex = 8;
            this.MovieLabel.Text = "Movie";
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(16, 182);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(49, 13);
            this.MovieTitleLabel.TabIndex = 9;
            this.MovieTitleLabel.Text = "Title: title";
            // 
            // MovieIDLabel
            // 
            this.MovieIDLabel.AutoSize = true;
            this.MovieIDLabel.Location = new System.Drawing.Point(16, 199);
            this.MovieIDLabel.Name = "MovieIDLabel";
            this.MovieIDLabel.Size = new System.Drawing.Size(64, 13);
            this.MovieIDLabel.TabIndex = 10;
            this.MovieIDLabel.Text = "Movie ID: id";
            // 
            // FufillButton
            // 
            this.FufillButton.Location = new System.Drawing.Point(75, 250);
            this.FufillButton.Name = "FufillButton";
            this.FufillButton.Size = new System.Drawing.Size(100, 50);
            this.FufillButton.TabIndex = 11;
            this.FufillButton.Text = "Fufill Order";
            this.FufillButton.UseVisualStyleBackColor = true;
            this.FufillButton.Click += new System.EventHandler(this.FufillOrderButton_Click);
            // 
            // FufillOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Controls.Add(this.FufillButton);
            this.Controls.Add(this.MovieIDLabel);
            this.Controls.Add(this.MovieTitleLabel);
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PostalCodeLabel);
            this.Controls.Add(this.ProvenceLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.StreetAddressLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.ShippingTitleLabel);
            this.Name = "FufillOrderForm";
            this.Text = "FufillOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShippingTitleLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label StreetAddressLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label ProvenceLabel;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.Label MovieIDLabel;
        private System.Windows.Forms.Button FufillButton;
    }
}