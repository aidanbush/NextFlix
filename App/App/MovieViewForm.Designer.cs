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
            this.RatingLabel = new System.Windows.Forms.Label();
            this.RatingSlider = new System.Windows.Forms.TrackBar();
            this.RatingButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RatingSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(21, 9);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(159, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "NAME OF MOVIE HERE";
            // 
            // MovieCastLabel
            // 
            this.MovieCastLabel.AutoSize = true;
            this.MovieCastLabel.Location = new System.Drawing.Point(269, 97);
            this.MovieCastLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieCastLabel.Name = "MovieCastLabel";
            this.MovieCastLabel.Size = new System.Drawing.Size(118, 17);
            this.MovieCastLabel.TabIndex = 1;
            this.MovieCastLabel.Text = "CAST OF MOVIE:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(270, 47);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(143, 17);
            this.GenreLabel.TabIndex = 2;
            this.GenreLabel.Text = "GENRE GOES HERE";
            // 
            // CopyLabel
            // 
            this.CopyLabel.AutoSize = true;
            this.CopyLabel.Location = new System.Drawing.Point(270, 147);
            this.CopyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CopyLabel.Name = "CopyLabel";
            this.CopyLabel.Size = new System.Drawing.Size(144, 17);
            this.CopyLabel.TabIndex = 3;
            this.CopyLabel.Text = "NUMBER OF COPIES";
            // 
            // RentButton
            // 
            this.RentButton.Location = new System.Drawing.Point(11, 362);
            this.RentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(246, 99);
            this.RentButton.TabIndex = 4;
            this.RentButton.Text = "Rent This Movie";
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(253, 301);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(16, 17);
            this.RatingLabel.TabIndex = 5;
            this.RatingLabel.Text = "0";
            // 
            // RatingSlider
            // 
            this.RatingSlider.Location = new System.Drawing.Point(11, 301);
            this.RatingSlider.Maximum = 5;
            this.RatingSlider.Name = "RatingSlider";
            this.RatingSlider.Size = new System.Drawing.Size(246, 56);
            this.RatingSlider.TabIndex = 6;
            this.RatingSlider.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // RatingButton
            // 
            this.RatingButton.Location = new System.Drawing.Point(11, 362);
            this.RatingButton.Margin = new System.Windows.Forms.Padding(2);
            this.RatingButton.Name = "RatingButton";
            this.RatingButton.Size = new System.Drawing.Size(246, 99);
            this.RatingButton.TabIndex = 7;
            this.RatingButton.Text = "Rate This Movie";
            this.RatingButton.UseVisualStyleBackColor = true;
            this.RatingButton.Click += new System.EventHandler(this.RatingButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(17, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 228);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rating";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MovieViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RatingButton);
            this.Controls.Add(this.RatingSlider);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.RentButton);
            this.Controls.Add(this.CopyLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.MovieCastLabel);
            this.Controls.Add(this.NameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MovieViewForm";
            this.Text = "MovieViewForm";
            this.Load += new System.EventHandler(this.MovieViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RatingSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MovieCastLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label CopyLabel;
        private System.Windows.Forms.Button RentButton;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TrackBar RatingSlider;
        private System.Windows.Forms.Button RatingButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}