namespace App
{
    partial class AddMovieForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.CopyAmountBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FeesBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 515);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 55);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Location = new System.Drawing.Point(158, 514);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(138, 56);
            this.AddMovieButton.TabIndex = 19;
            this.AddMovieButton.Text = "Add Movie";
            this.AddMovieButton.UseVisualStyleBackColor = true;
            this.AddMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Title:";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(18, 51);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(193, 31);
            this.TitleBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Genre:";
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(18, 141);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(138, 31);
            this.GenreBox.TabIndex = 24;
            // 
            // CopyAmountBox
            // 
            this.CopyAmountBox.Location = new System.Drawing.Point(18, 242);
            this.CopyAmountBox.Name = "CopyAmountBox";
            this.CopyAmountBox.Size = new System.Drawing.Size(193, 31);
            this.CopyAmountBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Amount of copies:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Fees";
            // 
            // FeesBox
            // 
            this.FeesBox.Location = new System.Drawing.Point(18, 340);
            this.FeesBox.Name = "FeesBox";
            this.FeesBox.Size = new System.Drawing.Size(193, 31);
            this.FeesBox.TabIndex = 29;
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 619);
            this.Controls.Add(this.FeesBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CopyAmountBox);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddMovieButton);
            this.Name = "AddMovieForm";
            this.Text = "Add Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GenreBox;
        private System.Windows.Forms.TextBox CopyAmountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FeesBox;
    }
}