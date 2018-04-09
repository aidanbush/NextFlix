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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.personalSuggestionsDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.myMoviesPanel = new System.Windows.Forms.Panel();
            this.ReturnMovieButton = new System.Windows.Forms.Button();
            this.MoviesPendingDataGridView = new System.Windows.Forms.DataGridView();
            this.MoviesPendingLabel = new System.Windows.Forms.Label();
            this.RateMovieButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.MoviesRentedThisMonth = new System.Windows.Forms.DataGridView();
            this.MoviesQueuedGridView = new System.Windows.Forms.DataGridView();
            this.RentedMoviesGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RentButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MovieGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rentMoviePanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalSuggestionsDataGridView)).BeginInit();
            this.myMoviesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesPendingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesRentedThisMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesQueuedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentedMoviesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieGridView)).BeginInit();
            this.rentMoviePanel.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1091, 26);
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
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.moviesToolStripMenuItem.Text = "Movies";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // movieHomeToolStripMenuItem
            // 
            this.movieHomeToolStripMenuItem.Name = "movieHomeToolStripMenuItem";
            this.movieHomeToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.movieHomeToolStripMenuItem.Text = "Rent A Movie";
            this.movieHomeToolStripMenuItem.Click += new System.EventHandler(this.movieHomeToolStripMenuItem_Click);
            // 
            // myMoviesToolStripMenuItem
            // 
            this.myMoviesToolStripMenuItem.Name = "myMoviesToolStripMenuItem";
            this.myMoviesToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.myMoviesToolStripMenuItem.Text = "My Movies";
            this.myMoviesToolStripMenuItem.Click += new System.EventHandler(this.myMoviesToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.myProfileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
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
            this.ProfilePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(1091, 605);
            this.ProfilePanel.TabIndex = 1;
            // 
            // EditPaymentInfo
            // 
            this.EditPaymentInfo.Location = new System.Drawing.Point(11, 354);
            this.EditPaymentInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditPaymentInfo.Name = "EditPaymentInfo";
            this.EditPaymentInfo.Size = new System.Drawing.Size(149, 33);
            this.EditPaymentInfo.TabIndex = 10;
            this.EditPaymentInfo.Text = "Edit Payment Info";
            this.EditPaymentInfo.UseVisualStyleBackColor = true;
            this.EditPaymentInfo.Click += new System.EventHandler(this.EditPaymentInfo_Click);
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(13, 294);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(62, 17);
            this.NumberLabel.TabIndex = 9;
            this.NumberLabel.Text = "Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Payment Information:";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(13, 202);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(149, 33);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Edit Information";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(13, 166);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(46, 17);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(13, 137);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(53, 17);
            this.PhoneLabel.TabIndex = 5;
            this.PhoneLabel.Text = "Phone:";
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Location = new System.Drawing.Point(79, 110);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(45, 17);
            this.ProvinceLabel.TabIndex = 4;
            this.ProvinceLabel.Text = "State:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(13, 110);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 17);
            this.CityLabel.TabIndex = 3;
            this.CityLabel.Text = "City:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(13, 82);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(68, 17);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 57);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Information:";
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.label5);
            this.HomePanel.Controls.Add(this.button1);
            this.HomePanel.Controls.Add(this.personalSuggestionsDataGridView);
            this.HomePanel.Controls.Add(this.label3);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1091, 605);
            this.HomePanel.TabIndex = 10;
            this.HomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomePanel_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(392, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Here is some suggested movies based on your prefferences:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rent movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RentButton_click);
            // 
            // personalSuggestionsDataGridView
            // 
            this.personalSuggestionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personalSuggestionsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.personalSuggestionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalSuggestionsDataGridView.Location = new System.Drawing.Point(34, 110);
            this.personalSuggestionsDataGridView.Name = "personalSuggestionsDataGridView";
            this.personalSuggestionsDataGridView.RowHeadersVisible = false;
            this.personalSuggestionsDataGridView.RowTemplate.Height = 24;
            this.personalSuggestionsDataGridView.Size = new System.Drawing.Size(710, 302);
            this.personalSuggestionsDataGridView.TabIndex = 1;
            this.personalSuggestionsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personalSuggestionsDataGridView_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hello, User";
            // 
            // myMoviesPanel
            // 
            this.myMoviesPanel.Controls.Add(this.ReturnMovieButton);
            this.myMoviesPanel.Controls.Add(this.MoviesPendingDataGridView);
            this.myMoviesPanel.Controls.Add(this.MoviesPendingLabel);
            this.myMoviesPanel.Controls.Add(this.RateMovieButton);
            this.myMoviesPanel.Controls.Add(this.label9);
            this.myMoviesPanel.Controls.Add(this.MoviesRentedThisMonth);
            this.myMoviesPanel.Controls.Add(this.MoviesQueuedGridView);
            this.myMoviesPanel.Controls.Add(this.RentedMoviesGridView);
            this.myMoviesPanel.Controls.Add(this.label8);
            this.myMoviesPanel.Controls.Add(this.label7);
            this.myMoviesPanel.Controls.Add(this.label4);
            this.myMoviesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myMoviesPanel.Location = new System.Drawing.Point(0, 0);
            this.myMoviesPanel.Margin = new System.Windows.Forms.Padding(4);
            this.myMoviesPanel.Name = "myMoviesPanel";
            this.myMoviesPanel.Size = new System.Drawing.Size(1091, 605);
            this.myMoviesPanel.TabIndex = 1;
            // 
            // ReturnMovieButton
            // 
            this.ReturnMovieButton.Location = new System.Drawing.Point(175, 33);
            this.ReturnMovieButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnMovieButton.Name = "ReturnMovieButton";
            this.ReturnMovieButton.Size = new System.Drawing.Size(107, 30);
            this.ReturnMovieButton.TabIndex = 11;
            this.ReturnMovieButton.Text = "Return Movie";
            this.ReturnMovieButton.UseVisualStyleBackColor = true;
            this.ReturnMovieButton.Click += new System.EventHandler(this.ReturnMovieButton_Click);
            // 
            // MoviesPendingDataGridView
            // 
            this.MoviesPendingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesPendingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MoviesPendingDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.MoviesPendingDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MoviesPendingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesPendingDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoviesPendingDataGridView.Location = new System.Drawing.Point(11, 325);
            this.MoviesPendingDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviesPendingDataGridView.Name = "MoviesPendingDataGridView";
            this.MoviesPendingDataGridView.RowHeadersVisible = false;
            this.MoviesPendingDataGridView.RowTemplate.Height = 33;
            this.MoviesPendingDataGridView.Size = new System.Drawing.Size(1073, 96);
            this.MoviesPendingDataGridView.TabIndex = 10;
            // 
            // MoviesPendingLabel
            // 
            this.MoviesPendingLabel.AutoSize = true;
            this.MoviesPendingLabel.Location = new System.Drawing.Point(11, 303);
            this.MoviesPendingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MoviesPendingLabel.Name = "MoviesPendingLabel";
            this.MoviesPendingLabel.Size = new System.Drawing.Size(108, 17);
            this.MoviesPendingLabel.TabIndex = 9;
            this.MoviesPendingLabel.Text = "Movies Pending";
            // 
            // RateMovieButton
            // 
            this.RateMovieButton.Location = new System.Drawing.Point(187, 426);
            this.RateMovieButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RateMovieButton.Name = "RateMovieButton";
            this.RateMovieButton.Size = new System.Drawing.Size(107, 30);
            this.RateMovieButton.TabIndex = 8;
            this.RateMovieButton.Text = "Rate Movie";
            this.RateMovieButton.UseVisualStyleBackColor = true;
            this.RateMovieButton.Click += new System.EventHandler(this.RateMovieButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Movies rented this month:";
            // 
            // MoviesRentedThisMonth
            // 
            this.MoviesRentedThisMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesRentedThisMonth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MoviesRentedThisMonth.BackgroundColor = System.Drawing.Color.White;
            this.MoviesRentedThisMonth.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MoviesRentedThisMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesRentedThisMonth.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoviesRentedThisMonth.Location = new System.Drawing.Point(11, 460);
            this.MoviesRentedThisMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviesRentedThisMonth.Name = "MoviesRentedThisMonth";
            this.MoviesRentedThisMonth.RowHeadersVisible = false;
            this.MoviesRentedThisMonth.RowTemplate.Height = 33;
            this.MoviesRentedThisMonth.Size = new System.Drawing.Size(1072, 131);
            this.MoviesRentedThisMonth.TabIndex = 6;
            this.MoviesRentedThisMonth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoviesRentedThisMonth_CellClick);
            // 
            // MoviesQueuedGridView
            // 
            this.MoviesQueuedGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesQueuedGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MoviesQueuedGridView.BackgroundColor = System.Drawing.Color.White;
            this.MoviesQueuedGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MoviesQueuedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesQueuedGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoviesQueuedGridView.Location = new System.Drawing.Point(11, 202);
            this.MoviesQueuedGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviesQueuedGridView.Name = "MoviesQueuedGridView";
            this.MoviesQueuedGridView.RowHeadersVisible = false;
            this.MoviesQueuedGridView.RowTemplate.Height = 33;
            this.MoviesQueuedGridView.Size = new System.Drawing.Size(1073, 96);
            this.MoviesQueuedGridView.TabIndex = 5;
            this.MoviesQueuedGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoviesQueuedGridView_CellClick);
            // 
            // RentedMoviesGridView
            // 
            this.RentedMoviesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RentedMoviesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RentedMoviesGridView.BackgroundColor = System.Drawing.Color.White;
            this.RentedMoviesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RentedMoviesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentedMoviesGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RentedMoviesGridView.Location = new System.Drawing.Point(11, 68);
            this.RentedMoviesGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RentedMoviesGridView.Name = "RentedMoviesGridView";
            this.RentedMoviesGridView.RowHeadersVisible = false;
            this.RentedMoviesGridView.RowTemplate.Height = 33;
            this.RentedMoviesGridView.Size = new System.Drawing.Size(1073, 96);
            this.RentedMoviesGridView.TabIndex = 4;
            this.RentedMoviesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoviesCurrentlyRentedCellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Movies currently rented:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Movies in your queue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Your current movies:";
            // 
            // RentButton
            // 
            this.RentButton.Location = new System.Drawing.Point(17, 254);
            this.RentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(117, 42);
            this.RentButton.TabIndex = 1;
            this.RentButton.Text = "Rent movie";
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.RentButton_click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Available movies:";
            // 
            // MovieGridView
            // 
            this.MovieGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MovieGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MovieGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MovieGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MovieGridView.Location = new System.Drawing.Point(13, 82);
            this.MovieGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieGridView.Name = "MovieGridView";
            this.MovieGridView.RowHeadersVisible = false;
            this.MovieGridView.RowTemplate.Height = 33;
            this.MovieGridView.Size = new System.Drawing.Size(487, 146);
            this.MovieGridView.TabIndex = 2;
            this.MovieGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieGridView_CellContentClick);
            this.MovieGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieGridView_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // rentMoviePanel
            // 
            this.rentMoviePanel.Controls.Add(this.SearchButton);
            this.rentMoviePanel.Controls.Add(this.comboBox1);
            this.rentMoviePanel.Controls.Add(this.MovieGridView);
            this.rentMoviePanel.Controls.Add(this.label6);
            this.rentMoviePanel.Controls.Add(this.RentButton);
            this.rentMoviePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentMoviePanel.Location = new System.Drawing.Point(0, 0);
            this.rentMoviePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentMoviePanel.Name = "rentMoviePanel";
            this.rentMoviePanel.Size = new System.Drawing.Size(1091, 605);
            this.rentMoviePanel.TabIndex = 2;
            this.rentMoviePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rentMoviePanel_Paint);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(140, 254);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(128, 44);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search For Movie";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 605);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.ProfilePanel);
            this.Controls.Add(this.rentMoviePanel);
            this.Controls.Add(this.myMoviesPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerForm";
            this.Text = "Grettings, User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerFormClosed);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalSuggestionsDataGridView)).EndInit();
            this.myMoviesPanel.ResumeLayout(false);
            this.myMoviesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesPendingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesRentedThisMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesQueuedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentedMoviesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieGridView)).EndInit();
            this.rentMoviePanel.ResumeLayout(false);
            this.rentMoviePanel.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditPaymentInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView MoviesRentedThisMonth;
        private System.Windows.Forms.DataGridView MoviesQueuedGridView;
        private System.Windows.Forms.DataGridView RentedMoviesGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RateMovieButton;
        private System.Windows.Forms.Button RentButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView MovieGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel rentMoviePanel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView MoviesPendingDataGridView;
        private System.Windows.Forms.Label MoviesPendingLabel;
        private System.Windows.Forms.Button ReturnMovieButton;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView personalSuggestionsDataGridView;
    }
}
