namespace App
{
    partial class ManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.AddButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerRepresentativesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateRatingsButton = new System.Windows.Forms.Button();
            this.FulfillOrderButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.OrderMovieButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ManagerViewPanel = new System.Windows.Forms.Panel();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.ManagerViewDataGridView = new System.Windows.Forms.DataGridView();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.DateRangeLabel = new System.Windows.Forms.Label();
            this.SalesReportLabel = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ManagerViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(73, 47);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(134, 58);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1443, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.customerRepresentativesToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.salesReportsToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.customerQueueToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.CustomerLoad);
            // 
            // customerRepresentativesToolStripMenuItem
            // 
            this.customerRepresentativesToolStripMenuItem.Name = "customerRepresentativesToolStripMenuItem";
            this.customerRepresentativesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.customerRepresentativesToolStripMenuItem.Text = "Customer Representatives";
            this.customerRepresentativesToolStripMenuItem.Click += new System.EventHandler(this.CustomerRepLoad);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.MoviesLoad);
            // 
            // salesReportsToolStripMenuItem
            // 
            this.salesReportsToolStripMenuItem.Name = "salesReportsToolStripMenuItem";
            this.salesReportsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.salesReportsToolStripMenuItem.Text = "Sales Reports";
            this.salesReportsToolStripMenuItem.Click += new System.EventHandler(this.SalesRepotsLoad);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.OrderLoad);
            // 
            // customerQueueToolStripMenuItem
            // 
            this.customerQueueToolStripMenuItem.Name = "customerQueueToolStripMenuItem";
            this.customerQueueToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.customerQueueToolStripMenuItem.Text = "Customer Queue";
            this.customerQueueToolStripMenuItem.Click += new System.EventHandler(this.QueueLoad);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(73, 105);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(134, 55);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(73, 162);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(134, 61);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateRatingsButton
            // 
            this.UpdateRatingsButton.Location = new System.Drawing.Point(73, 222);
            this.UpdateRatingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateRatingsButton.Name = "UpdateRatingsButton";
            this.UpdateRatingsButton.Size = new System.Drawing.Size(134, 69);
            this.UpdateRatingsButton.TabIndex = 8;
            this.UpdateRatingsButton.Text = "Update Customer Ratings";
            this.UpdateRatingsButton.UseVisualStyleBackColor = true;
            this.UpdateRatingsButton.Click += new System.EventHandler(this.UpdateRatingsButton_Click);
            // 
            // FulfillOrderButton
            // 
            this.FulfillOrderButton.Location = new System.Drawing.Point(73, 49);
            this.FulfillOrderButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FulfillOrderButton.Name = "FulfillOrderButton";
            this.FulfillOrderButton.Size = new System.Drawing.Size(134, 55);
            this.FulfillOrderButton.TabIndex = 9;
            this.FulfillOrderButton.Text = "Fulfill order";
            this.FulfillOrderButton.UseVisualStyleBackColor = true;
            this.FulfillOrderButton.Visible = false;
            this.FulfillOrderButton.Click += new System.EventHandler(this.FulfillOrderButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.Location = new System.Drawing.Point(1364, 27);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 10;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // OrderMovieButton
            // 
            this.OrderMovieButton.Location = new System.Drawing.Point(73, 49);
            this.OrderMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.OrderMovieButton.Name = "OrderMovieButton";
            this.OrderMovieButton.Size = new System.Drawing.Size(134, 55);
            this.OrderMovieButton.TabIndex = 11;
            this.OrderMovieButton.Text = "Place Order";
            this.OrderMovieButton.UseVisualStyleBackColor = true;
            this.OrderMovieButton.Click += new System.EventHandler(this.OrderMovieButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(271, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 664);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ManagerViewPanel
            // 
            this.ManagerViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManagerViewPanel.Controls.Add(this.GenreComboBox);
            this.ManagerViewPanel.Controls.Add(this.GenerateReportButton);
            this.ManagerViewPanel.Controls.Add(this.ManagerViewDataGridView);
            this.ManagerViewPanel.Controls.Add(this.GenreLabel);
            this.ManagerViewPanel.Controls.Add(this.ToDateTimePicker);
            this.ManagerViewPanel.Controls.Add(this.FromDateTimePicker);
            this.ManagerViewPanel.Controls.Add(this.ToLabel);
            this.ManagerViewPanel.Controls.Add(this.FromLabel);
            this.ManagerViewPanel.Controls.Add(this.DateRangeLabel);
            this.ManagerViewPanel.Controls.Add(this.SalesReportLabel);
            this.ManagerViewPanel.Location = new System.Drawing.Point(0, 27);
            this.ManagerViewPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ManagerViewPanel.Name = "ManagerViewPanel";
            this.ManagerViewPanel.Size = new System.Drawing.Size(1443, 731);
            this.ManagerViewPanel.TabIndex = 12;
            this.ManagerViewPanel.Visible = false;
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Location = new System.Drawing.Point(16, 180);
            this.GenerateReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(100, 30);
            this.GenerateReportButton.TabIndex = 9;
            this.GenerateReportButton.Text = "Generate Report";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // ManagerViewDataGridView
            // 
            this.ManagerViewDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManagerViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagerViewDataGridView.Location = new System.Drawing.Point(289, 58);
            this.ManagerViewDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ManagerViewDataGridView.Name = "ManagerViewDataGridView";
            this.ManagerViewDataGridView.Size = new System.Drawing.Size(1123, 637);
            this.ManagerViewDataGridView.TabIndex = 8;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(13, 139);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(128, 13);
            this.GenreLabel.TabIndex = 6;
            this.GenreLabel.Text = "Genre (leave blank for all)";
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Location = new System.Drawing.Point(57, 105);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ToDateTimePicker.TabIndex = 5;
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Location = new System.Drawing.Point(57, 80);
            this.FromDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FromDateTimePicker.TabIndex = 4;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(13, 105);
            this.ToLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(20, 13);
            this.ToLabel.TabIndex = 3;
            this.ToLabel.Text = "To";
            this.ToLabel.Click += new System.EventHandler(this.ToLabel_Click);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(13, 80);
            this.FromLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(33, 13);
            this.FromLabel.TabIndex = 2;
            this.FromLabel.Text = "From:";
            // 
            // DateRangeLabel
            // 
            this.DateRangeLabel.AutoSize = true;
            this.DateRangeLabel.Location = new System.Drawing.Point(13, 58);
            this.DateRangeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateRangeLabel.Name = "DateRangeLabel";
            this.DateRangeLabel.Size = new System.Drawing.Size(65, 13);
            this.DateRangeLabel.TabIndex = 1;
            this.DateRangeLabel.Text = "Date Range";
            // 
            // SalesReportLabel
            // 
            this.SalesReportLabel.AutoSize = true;
            this.SalesReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReportLabel.Location = new System.Drawing.Point(10, 33);
            this.SalesReportLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SalesReportLabel.Name = "SalesReportLabel";
            this.SalesReportLabel.Size = new System.Drawing.Size(102, 20);
            this.SalesReportLabel.TabIndex = 0;
            this.SalesReportLabel.Text = "Sales Report";
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Action",
            "Foreign"});
            this.GenreComboBox.Location = new System.Drawing.Point(16, 153);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(121, 21);
            this.GenreComboBox.TabIndex = 10;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 758);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ManagerViewPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdateRatingsButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.OrderMovieButton);
            this.Controls.Add(this.FulfillOrderButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerFormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ManagerViewPanel.ResumeLayout(false);
            this.ManagerViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerRepresentativesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateRatingsButton;
        private System.Windows.Forms.Button FulfillOrderButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button OrderMovieButton;
        private System.Windows.Forms.ToolStripMenuItem customerQueueToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel ManagerViewPanel;
        private System.Windows.Forms.Label SalesReportLabel;
        private System.Windows.Forms.Label DateRangeLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.DataGridView ManagerViewDataGridView;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.ComboBox GenreComboBox;
    }
}
