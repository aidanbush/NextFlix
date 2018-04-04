namespace App
{
    partial class CustomerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.EditPaymentInfo = new System.Windows.Forms.Button();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.myMoviesPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MoviesQueuedGridView = new System.Windows.Forms.DataGridView();
            this.RentedMoviesGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RentMovieButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rentMoviePanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.MovieGridView = new System.Windows.Forms.DataGridView();
            this.RentButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.myMoviesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesQueuedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentedMoviesGridView)).BeginInit();
            this.rentMoviePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1154, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.movieHomeToolStripMenuItem,
            this.myMoviesToolStripMenuItem});
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.moviesToolStripMenuItem.Text = "Movies";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // movieHomeToolStripMenuItem
            // 
            this.movieHomeToolStripMenuItem.Name = "movieHomeToolStripMenuItem";
            this.movieHomeToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.movieHomeToolStripMenuItem.Text = "Rent A Movie";
            this.movieHomeToolStripMenuItem.Click += new System.EventHandler(this.movieHomeToolStripMenuItem_Click);
            // 
            // myMoviesToolStripMenuItem
            // 
            this.myMoviesToolStripMenuItem.Name = "myMoviesToolStripMenuItem";
            this.myMoviesToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.myMoviesToolStripMenuItem.Text = "My Movies";
            this.myMoviesToolStripMenuItem.Click += new System.EventHandler(this.myMoviesToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(95, 36);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(223, 38);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.myProfileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.Controls.Add(this.EditPaymentInfo);
            this.ProfilePanel.Controls.Add(this.NumberLabel);
            this.ProfilePanel.Controls.Add(this.label2);
            this.ProfilePanel.Controls.Add(this.EditButton);
            this.ProfilePanel.Controls.Add(this.EmailLabel);
            this.ProfilePanel.Controls.Add(this.PhoneLabel);
            this.ProfilePanel.Controls.Add(this.ProvinceLabel);
            this.ProfilePanel.Controls.Add(this.CityLabel);
            this.ProfilePanel.Controls.Add(this.AddressLabel);
            this.ProfilePanel.Controls.Add(this.NameLabel);
            this.ProfilePanel.Controls.Add(this.label1);
            this.ProfilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.ProfilePanel.Margin = new System.Windows.Forms.Padding(4);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(1154, 783);
            this.ProfilePanel.TabIndex = 1;
            // 
            // EditPaymentInfo
            // 
            this.EditPaymentInfo.Location = new System.Drawing.Point(16, 554);
            this.EditPaymentInfo.Name = "EditPaymentInfo";
            this.EditPaymentInfo.Size = new System.Drawing.Size(224, 52);
            this.EditPaymentInfo.TabIndex = 10;
            this.EditPaymentInfo.Text = "Edit Payment Info";
            this.EditPaymentInfo.UseVisualStyleBackColor = true;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(19, 460);
            this.NumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(93, 25);
            this.NumberLabel.TabIndex = 9;
            this.NumberLabel.Text = "Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 408);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Payment Information:";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(19, 316);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(224, 52);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Edit Information";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(19, 260);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(71, 25);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(19, 214);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(80, 25);
            this.PhoneLabel.TabIndex = 5;
            this.PhoneLabel.Text = "Phone:";
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Location = new System.Drawing.Point(119, 170);
            this.ProvinceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(68, 25);
            this.ProvinceLabel.TabIndex = 4;
            this.ProvinceLabel.Text = "State:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(19, 170);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(55, 25);
            this.CityLabel.TabIndex = 3;
            this.CityLabel.Text = "City:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(19, 129);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(103, 25);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(19, 89);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Information:";
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.label3);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(4);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1154, 783);
            this.HomePanel.TabIndex = 10;
            this.HomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomePanel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hello, User";
            // 
            // myMoviesPanel
            // 
            this.myMoviesPanel.Controls.Add(this.label9);
            this.myMoviesPanel.Controls.Add(this.dataGridView1);
            this.myMoviesPanel.Controls.Add(this.MoviesQueuedGridView);
            this.myMoviesPanel.Controls.Add(this.RentedMoviesGridView);
            this.myMoviesPanel.Controls.Add(this.label8);
            this.myMoviesPanel.Controls.Add(this.label7);
            this.myMoviesPanel.Controls.Add(this.RentMovieButton);
            this.myMoviesPanel.Controls.Add(this.label4);
            this.myMoviesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myMoviesPanel.Location = new System.Drawing.Point(0, 0);
            this.myMoviesPanel.Name = "myMoviesPanel";
            this.myMoviesPanel.Size = new System.Drawing.Size(1154, 783);
            this.myMoviesPanel.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Movies rented this month:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 499);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // MoviesQueuedGridView
            // 
            this.MoviesQueuedGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesQueuedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesQueuedGridView.Location = new System.Drawing.Point(16, 316);
            this.MoviesQueuedGridView.Name = "MoviesQueuedGridView";
            this.MoviesQueuedGridView.RowTemplate.Height = 33;
            this.MoviesQueuedGridView.Size = new System.Drawing.Size(1128, 150);
            this.MoviesQueuedGridView.TabIndex = 5;
            // 
            // RentedMoviesGridView
            // 
            this.RentedMoviesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RentedMoviesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentedMoviesGridView.Location = new System.Drawing.Point(16, 107);
            this.RentedMoviesGridView.Name = "RentedMoviesGridView";
            this.RentedMoviesGridView.RowTemplate.Height = 33;
            this.RentedMoviesGridView.Size = new System.Drawing.Size(1128, 150);
            this.RentedMoviesGridView.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Movies currently rented:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Movies in your queue";
            // 
            // RentMovieButton
            // 
            this.RentMovieButton.Location = new System.Drawing.Point(16, 690);
            this.RentMovieButton.Name = "RentMovieButton";
            this.RentMovieButton.Size = new System.Drawing.Size(204, 81);
            this.RentMovieButton.TabIndex = 1;
            this.RentMovieButton.Text = "Rent a movie";
            this.RentMovieButton.UseVisualStyleBackColor = true;
            this.RentMovieButton.Click += new System.EventHandler(this.RentMovieButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Your current movies:";
            // 
            // rentMoviePanel
            // 
            this.rentMoviePanel.Controls.Add(this.label6);
            this.rentMoviePanel.Controls.Add(this.MovieGridView);
            this.rentMoviePanel.Controls.Add(this.RentButton);
            this.rentMoviePanel.Controls.Add(this.label5);
            this.rentMoviePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentMoviePanel.Location = new System.Drawing.Point(0, 0);
            this.rentMoviePanel.Name = "rentMoviePanel";
            this.rentMoviePanel.Size = new System.Drawing.Size(1154, 783);
            this.rentMoviePanel.TabIndex = 2;
            this.rentMoviePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rentMoviePanel_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Available movies:";
            // 
            // MovieGridView
            // 
            this.MovieGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieGridView.Location = new System.Drawing.Point(25, 145);
            this.MovieGridView.Name = "MovieGridView";
            this.MovieGridView.RowTemplate.Height = 33;
            this.MovieGridView.Size = new System.Drawing.Size(1126, 230);
            this.MovieGridView.TabIndex = 2;
            this.MovieGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieGridView_CellContentClick);
            // 
            // RentButton
            // 
            this.RentButton.Location = new System.Drawing.Point(25, 396);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(175, 66);
            this.RentButton.TabIndex = 1;
            this.RentButton.Text = "Rent movie";
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.RentButton_click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Movies to rent:";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 783);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rentMoviePanel);
            this.Controls.Add(this.myMoviesPanel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.ProfilePanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerForm";
            this.Text = "Grettings, User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerFormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.myMoviesPanel.ResumeLayout(false);
            this.myMoviesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesQueuedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentedMoviesGridView)).EndInit();
            this.rentMoviePanel.ResumeLayout(false);
            this.rentMoviePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HomePanel;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel myMoviesPanel;
        private System.Windows.Forms.Button RentMovieButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel rentMoviePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView MovieGridView;
        private System.Windows.Forms.Button RentButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EditPaymentInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView MoviesQueuedGridView;
        private System.Windows.Forms.DataGridView RentedMoviesGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}