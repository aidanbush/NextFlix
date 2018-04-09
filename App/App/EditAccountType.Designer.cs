namespace App
{
    partial class EditAccountType
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
            this.ChooseAccountButton = new System.Windows.Forms.Button();
            this.currentTypeLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.AccountTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.MoviesAllowedLabel = new System.Windows.Forms.Label();
            this.RentalsAllowedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseAccountButton
            // 
            this.ChooseAccountButton.Location = new System.Drawing.Point(59, 135);
            this.ChooseAccountButton.Name = "ChooseAccountButton";
            this.ChooseAccountButton.Size = new System.Drawing.Size(173, 66);
            this.ChooseAccountButton.TabIndex = 0;
            this.ChooseAccountButton.Text = "Choose This Account Type";
            this.ChooseAccountButton.UseVisualStyleBackColor = true;
            this.ChooseAccountButton.Click += new System.EventHandler(this.ChooseAccountButton_Click);
            // 
            // currentTypeLabel
            // 
            this.currentTypeLabel.AutoSize = true;
            this.currentTypeLabel.Location = new System.Drawing.Point(59, 34);
            this.currentTypeLabel.Name = "currentTypeLabel";
            this.currentTypeLabel.Size = new System.Drawing.Size(224, 25);
            this.currentTypeLabel.TabIndex = 1;
            this.currentTypeLabel.Text = "Current account type: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 66);
            this.button2.TabIndex = 6;
            this.button2.Text = "Deactivate Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AccountTypeBox
            // 
            this.AccountTypeBox.FormattingEnabled = true;
            this.AccountTypeBox.Items.AddRange(new object[] {
            "Limited",
            "Bronze",
            "Silver",
            "Gold"});
            this.AccountTypeBox.Location = new System.Drawing.Point(59, 79);
            this.AccountTypeBox.Name = "AccountTypeBox";
            this.AccountTypeBox.Size = new System.Drawing.Size(208, 33);
            this.AccountTypeBox.TabIndex = 7;
            this.AccountTypeBox.SelectedIndexChanged += new System.EventHandler(this.IndexChosen);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Account Details:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(400, 79);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(67, 25);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Price:";
            // 
            // MoviesAllowedLabel
            // 
            this.MoviesAllowedLabel.AutoSize = true;
            this.MoviesAllowedLabel.Location = new System.Drawing.Point(400, 116);
            this.MoviesAllowedLabel.Name = "MoviesAllowedLabel";
            this.MoviesAllowedLabel.Size = new System.Drawing.Size(254, 25);
            this.MoviesAllowedLabel.TabIndex = 10;
            this.MoviesAllowedLabel.Text = "Movies allowed at a time:";
            // 
            // RentalsAllowedLabel
            // 
            this.RentalsAllowedLabel.AutoSize = true;
            this.RentalsAllowedLabel.Location = new System.Drawing.Point(400, 152);
            this.RentalsAllowedLabel.Name = "RentalsAllowedLabel";
            this.RentalsAllowedLabel.Size = new System.Drawing.Size(278, 25);
            this.RentalsAllowedLabel.TabIndex = 11;
            this.RentalsAllowedLabel.Text = "Rentals allowed per month: ";
            // 
            // EditAccountType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 652);
            this.Controls.Add(this.RentalsAllowedLabel);
            this.Controls.Add(this.MoviesAllowedLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountTypeBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.currentTypeLabel);
            this.Controls.Add(this.ChooseAccountButton);
            this.Name = "EditAccountType";
            this.Text = "EditAccountType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseAccountButton;
        private System.Windows.Forms.Label currentTypeLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox AccountTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label MoviesAllowedLabel;
        private System.Windows.Forms.Label RentalsAllowedLabel;
    }
}