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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddActor = new System.Windows.Forms.Button();
            this.ActorList = new System.Windows.Forms.DataGridView();
            this.DeleteActor = new System.Windows.Forms.Button();
            this.EditActor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ActorList)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 453);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 35);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Location = new System.Drawing.Point(109, 452);
            this.AddMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(92, 36);
            this.AddMovieButton.TabIndex = 19;
            this.AddMovieButton.Text = "Add Movie";
            this.AddMovieButton.UseVisualStyleBackColor = true;
            this.AddMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Title: *";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(12, 33);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(130, 22);
            this.TitleBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Genre:";
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(12, 90);
            this.GenreBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(93, 22);
            this.GenreBox.TabIndex = 24;
            // 
            // CopyAmountBox
            // 
            this.CopyAmountBox.Location = new System.Drawing.Point(12, 155);
            this.CopyAmountBox.Margin = new System.Windows.Forms.Padding(2);
            this.CopyAmountBox.Name = "CopyAmountBox";
            this.CopyAmountBox.Size = new System.Drawing.Size(130, 22);
            this.CopyAmountBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Amount of copies: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Fees";
            // 
            // FeesBox
            // 
            this.FeesBox.Location = new System.Drawing.Point(12, 218);
            this.FeesBox.Margin = new System.Windows.Forms.Padding(2);
            this.FeesBox.Name = "FeesBox";
            this.FeesBox.Size = new System.Drawing.Size(130, 22);
            this.FeesBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 495);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "* Indicates mandatory fields";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Actors";
            // 
            // AddActor
            // 
            this.AddActor.Location = new System.Drawing.Point(13, 397);
            this.AddActor.Margin = new System.Windows.Forms.Padding(2);
            this.AddActor.Name = "AddActor";
            this.AddActor.Size = new System.Drawing.Size(92, 36);
            this.AddActor.TabIndex = 33;
            this.AddActor.Text = "Add Actor";
            this.AddActor.UseVisualStyleBackColor = true;
            this.AddActor.Click += new System.EventHandler(this.AddActor_Click);
            // 
            // ActorList
            // 
            this.ActorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ActorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActorList.Location = new System.Drawing.Point(13, 273);
            this.ActorList.Name = "ActorList";
            this.ActorList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ActorList.RowHeadersVisible = false;
            this.ActorList.RowHeadersWidth = 25;
            this.ActorList.RowTemplate.Height = 24;
            this.ActorList.Size = new System.Drawing.Size(342, 119);
            this.ActorList.TabIndex = 34;
            this.ActorList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActorList_CellClick);
            this.ActorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActorList_CellContentClick);
            // 
            // DeleteActor
            // 
            this.DeleteActor.Location = new System.Drawing.Point(205, 397);
            this.DeleteActor.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteActor.Name = "DeleteActor";
            this.DeleteActor.Size = new System.Drawing.Size(98, 36);
            this.DeleteActor.TabIndex = 35;
            this.DeleteActor.Text = "Delete Actor";
            this.DeleteActor.UseVisualStyleBackColor = true;
            this.DeleteActor.Click += new System.EventHandler(this.DeleteActor_Click);
            // 
            // EditActor
            // 
            this.EditActor.Location = new System.Drawing.Point(109, 397);
            this.EditActor.Margin = new System.Windows.Forms.Padding(2);
            this.EditActor.Name = "EditActor";
            this.EditActor.Size = new System.Drawing.Size(92, 36);
            this.EditActor.TabIndex = 36;
            this.EditActor.Text = "Edit Actor";
            this.EditActor.UseVisualStyleBackColor = true;
            this.EditActor.Click += new System.EventHandler(this.EditActor_Click);
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 519);
            this.Controls.Add(this.EditActor);
            this.Controls.Add(this.DeleteActor);
            this.Controls.Add(this.ActorList);
            this.Controls.Add(this.AddActor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddMovieForm";
            this.Text = "Add Movie";
            ((System.ComponentModel.ISupportInitialize)(this.ActorList)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddActor;
        private System.Windows.Forms.DataGridView ActorList;
        private System.Windows.Forms.Button DeleteActor;
        private System.Windows.Forms.Button EditActor;
    }
}