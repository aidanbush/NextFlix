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
            this.AddToMovieBtn = new System.Windows.Forms.Button();
            this.MovieActorList = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ActorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieActorList)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(15, 452);
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
            this.AddMovieButton.Location = new System.Drawing.Point(112, 452);
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
            this.label6.Location = new System.Drawing.Point(265, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Find An Actor and add them to the movie";
            // 
            // AddActor
            // 
            this.AddActor.Location = new System.Drawing.Point(505, 437);
            this.AddActor.Margin = new System.Windows.Forms.Padding(2);
            this.AddActor.Name = "AddActor";
            this.AddActor.Size = new System.Drawing.Size(98, 36);
            this.AddActor.TabIndex = 33;
            this.AddActor.Text = "New Actor";
            this.AddActor.UseVisualStyleBackColor = true;
            this.AddActor.Click += new System.EventHandler(this.AddActor_Click);
            // 
            // ActorList
            // 
            this.ActorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ActorList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActorList.Location = new System.Drawing.Point(268, 35);
            this.ActorList.Name = "ActorList";
            this.ActorList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ActorList.RowHeadersVisible = false;
            this.ActorList.RowHeadersWidth = 25;
            this.ActorList.RowTemplate.Height = 24;
            this.ActorList.Size = new System.Drawing.Size(540, 397);
            this.ActorList.TabIndex = 34;
            this.ActorList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActorList_CellClick);
            this.ActorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActorList_CellContentClick);
            // 
            // DeleteActor
            // 
            this.DeleteActor.Location = new System.Drawing.Point(705, 437);
            this.DeleteActor.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteActor.Name = "DeleteActor";
            this.DeleteActor.Size = new System.Drawing.Size(103, 36);
            this.DeleteActor.TabIndex = 35;
            this.DeleteActor.Text = "Delete Actor";
            this.DeleteActor.UseVisualStyleBackColor = true;
            this.DeleteActor.Click += new System.EventHandler(this.DeleteActor_Click);
            // 
            // EditActor
            // 
            this.EditActor.Location = new System.Drawing.Point(607, 437);
            this.EditActor.Margin = new System.Windows.Forms.Padding(2);
            this.EditActor.Name = "EditActor";
            this.EditActor.Size = new System.Drawing.Size(94, 36);
            this.EditActor.TabIndex = 36;
            this.EditActor.Text = "Edit Actor";
            this.EditActor.UseVisualStyleBackColor = true;
            this.EditActor.Click += new System.EventHandler(this.EditActor_Click);
            // 
            // AddToMovieBtn
            // 
            this.AddToMovieBtn.Location = new System.Drawing.Point(190, 282);
            this.AddToMovieBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddToMovieBtn.Name = "AddToMovieBtn";
            this.AddToMovieBtn.Size = new System.Drawing.Size(73, 47);
            this.AddToMovieBtn.TabIndex = 37;
            this.AddToMovieBtn.Text = "Add     <<";
            this.AddToMovieBtn.UseVisualStyleBackColor = true;
            this.AddToMovieBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MovieActorList
            // 
            this.MovieActorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MovieActorList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MovieActorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieActorList.Location = new System.Drawing.Point(12, 282);
            this.MovieActorList.Name = "MovieActorList";
            this.MovieActorList.RowHeadersVisible = false;
            this.MovieActorList.RowTemplate.Height = 24;
            this.MovieActorList.Size = new System.Drawing.Size(173, 150);
            this.MovieActorList.TabIndex = 38;
            this.MovieActorList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectActorInMovieList);
            this.MovieActorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieActorList_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 253);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Actors";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 50);
            this.button1.TabIndex = 40;
            this.button1.Text = "Remove >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Action",
            "Foreign"});
            this.GenreComboBox.Location = new System.Drawing.Point(12, 85);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(130, 24);
            this.GenreComboBox.TabIndex = 41;
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 516);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MovieActorList);
            this.Controls.Add(this.AddToMovieBtn);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddMovieButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddMovieForm";
            this.Text = "Add Movie";
            ((System.ComponentModel.ISupportInitialize)(this.ActorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieActorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button AddToMovieBtn;
        private System.Windows.Forms.DataGridView MovieActorList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox GenreComboBox;
    }
}