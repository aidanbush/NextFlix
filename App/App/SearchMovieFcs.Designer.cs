namespace App
{
    partial class SearchMovieForm
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
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MovieActorList = new System.Windows.Forms.DataGridView();
            this.AddToMovieBtn = new System.Windows.Forms.Button();
            this.ActorList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MovieActorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActorList)).BeginInit();
            this.SuspendLayout();
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Action",
            "Foreign"});
            this.GenreComboBox.Location = new System.Drawing.Point(44, 110);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(130, 24);
            this.GenreComboBox.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 50);
            this.button1.TabIndex = 60;
            this.button1.Text = "Remove >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Actors";
            // 
            // MovieActorList
            // 
            this.MovieActorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MovieActorList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MovieActorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieActorList.Location = new System.Drawing.Point(44, 179);
            this.MovieActorList.Name = "MovieActorList";
            this.MovieActorList.RowHeadersVisible = false;
            this.MovieActorList.RowTemplate.Height = 24;
            this.MovieActorList.Size = new System.Drawing.Size(173, 278);
            this.MovieActorList.TabIndex = 58;
            this.MovieActorList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectActorInMovieList);
            // 
            // AddToMovieBtn
            // 
            this.AddToMovieBtn.Location = new System.Drawing.Point(222, 354);
            this.AddToMovieBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddToMovieBtn.Name = "AddToMovieBtn";
            this.AddToMovieBtn.Size = new System.Drawing.Size(73, 47);
            this.AddToMovieBtn.TabIndex = 57;
            this.AddToMovieBtn.Text = "Add     <<";
            this.AddToMovieBtn.UseVisualStyleBackColor = true;
            this.AddToMovieBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ActorList
            // 
            this.ActorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ActorList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActorList.Location = new System.Drawing.Point(300, 60);
            this.ActorList.Name = "ActorList";
            this.ActorList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ActorList.RowHeadersVisible = false;
            this.ActorList.RowHeadersWidth = 25;
            this.ActorList.RowTemplate.Height = 24;
            this.ActorList.Size = new System.Drawing.Size(540, 397);
            this.ActorList.TabIndex = 54;
            this.ActorList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActorList_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Find An Actor and add them to the movie";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(41, 90);
            this.Genre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(52, 17);
            this.Genre.TabIndex = 46;
            this.Genre.Text = "Genre:";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(44, 58);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(130, 22);
            this.TitleBox.TabIndex = 45;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(41, 40);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(48, 17);
            this.Title.TabIndex = 44;
            this.Title.Text = "Title: *";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(48, 462);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(169, 47);
            this.SearchButton.TabIndex = 62;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchMovieF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 576);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MovieActorList);
            this.Controls.Add(this.AddToMovieBtn);
            this.Controls.Add(this.ActorList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.Title);
            this.Name = "SearchMovieF";
            this.Text = "SearchMovieFcs";
            ((System.ComponentModel.ISupportInitialize)(this.MovieActorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView MovieActorList;
        private System.Windows.Forms.Button AddToMovieBtn;
        private System.Windows.Forms.DataGridView ActorList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button SearchButton;
    }
}