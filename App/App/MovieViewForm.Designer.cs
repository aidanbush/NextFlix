namespace App
{
    partial class MovieViewForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.MovieCastLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.CopyLabel = new System.Windows.Forms.Label();
            this.RentButton = new System.Windows.Forms.Button();
            this.RatingButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 26);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(245, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "NAME OF MOVIE HERE";
            // 
            // MovieCastLabel
            // 
            this.MovieCastLabel.AutoSize = true;
            this.MovieCastLabel.Location = new System.Drawing.Point(339, 152);
            this.MovieCastLabel.Name = "MovieCastLabel";
            this.MovieCastLabel.Size = new System.Drawing.Size(182, 25);
            this.MovieCastLabel.TabIndex = 1;
            this.MovieCastLabel.Text = "CAST OF MOVIE:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(339, 75);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(216, 25);
            this.GenreLabel.TabIndex = 2;
            this.GenreLabel.Text = "GENRE GOES HERE";
            // 
            // CopyLabel
            // 
            this.CopyLabel.AutoSize = true;
            this.CopyLabel.Location = new System.Drawing.Point(344, 255);
            this.CopyLabel.Name = "CopyLabel";
            this.CopyLabel.Size = new System.Drawing.Size(222, 25);
            this.CopyLabel.TabIndex = 3;
            this.CopyLabel.Text = "NUMBER OF COPIES";
            // 
            // RentButton
            // 
            this.RentButton.Location = new System.Drawing.Point(36, 367);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(369, 154);
            this.RentButton.TabIndex = 4;
            this.RentButton.Text = "Rent This Movie";
            this.RentButton.UseVisualStyleBackColor = true;
            // 
            // RatingButton
            // 
            this.RatingButton.AutoSize = true;
            this.RatingButton.Location = new System.Drawing.Point(36, 548);
            this.RatingButton.Name = "RatingButton";
            this.RatingButton.Size = new System.Drawing.Size(74, 25);
            this.RatingButton.TabIndex = 5;
            this.RatingButton.Text = "Rating";
            // 
            // MovieViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 715);
            this.Controls.Add(this.RatingButton);
            this.Controls.Add(this.RentButton);
            this.Controls.Add(this.CopyLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.MovieCastLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "MovieViewForm";
            this.Text = "MovieViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MovieCastLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label CopyLabel;
        private System.Windows.Forms.Button RentButton;
        private System.Windows.Forms.Label RatingButton;
    }
}