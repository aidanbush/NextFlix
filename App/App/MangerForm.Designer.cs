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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.dataGridView1.Location = new System.Drawing.Point(542, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
=======
            this.dataGridView1.Location = new System.Drawing.Point(361, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
<<<<<<< HEAD
            this.dataGridView1.Size = new System.Drawing.Size(1382, 948);
=======
            this.dataGridView1.Size = new System.Drawing.Size(1401, 741);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AddButton
            // 
<<<<<<< HEAD
            this.AddButton.Location = new System.Drawing.Point(148, 150);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(268, 106);
=======
            this.AddButton.Location = new System.Drawing.Point(99, 96);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(179, 68);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
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
<<<<<<< HEAD
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 44);
=======
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1442, 28);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
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
<<<<<<< HEAD
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
=======
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
<<<<<<< HEAD
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(391, 38);
=======
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.CustomerLoad);
            // 
            // customerRepresentativesToolStripMenuItem
            // 
            this.customerRepresentativesToolStripMenuItem.Name = "customerRepresentativesToolStripMenuItem";
<<<<<<< HEAD
            this.customerRepresentativesToolStripMenuItem.Size = new System.Drawing.Size(391, 38);
=======
            this.customerRepresentativesToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.customerRepresentativesToolStripMenuItem.Text = "Customer Representatives";
            this.customerRepresentativesToolStripMenuItem.Click += new System.EventHandler(this.CustomerRepLoad);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
<<<<<<< HEAD
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(391, 38);
=======
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.MoviesLoad);
            // 
            // salesReportsToolStripMenuItem
            // 
            this.salesReportsToolStripMenuItem.Name = "salesReportsToolStripMenuItem";
<<<<<<< HEAD
            this.salesReportsToolStripMenuItem.Size = new System.Drawing.Size(391, 38);
=======
            this.salesReportsToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.salesReportsToolStripMenuItem.Text = "Sales Reports";
            this.salesReportsToolStripMenuItem.Click += new System.EventHandler(this.SalesRepotsLoad);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
<<<<<<< HEAD
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(391, 38);
=======
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.OrderLoad);
            // 
            // customerQueueToolStripMenuItem
            // 
            this.customerQueueToolStripMenuItem.Name = "customerQueueToolStripMenuItem";
            this.customerQueueToolStripMenuItem.Size = new System.Drawing.Size(391, 38);
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
<<<<<<< HEAD
            this.EditButton.Location = new System.Drawing.Point(148, 281);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(268, 106);
=======
            this.EditButton.Location = new System.Drawing.Point(99, 180);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(179, 68);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
<<<<<<< HEAD
            this.DeleteButton.Location = new System.Drawing.Point(148, 425);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(268, 106);
=======
            this.DeleteButton.Location = new System.Drawing.Point(99, 272);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(179, 68);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateRatingsButton
            // 
<<<<<<< HEAD
            this.UpdateRatingsButton.Location = new System.Drawing.Point(148, 560);
            this.UpdateRatingsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateRatingsButton.Name = "UpdateRatingsButton";
            this.UpdateRatingsButton.Size = new System.Drawing.Size(268, 106);
=======
            this.UpdateRatingsButton.Location = new System.Drawing.Point(99, 358);
            this.UpdateRatingsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateRatingsButton.Name = "UpdateRatingsButton";
            this.UpdateRatingsButton.Size = new System.Drawing.Size(179, 68);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.UpdateRatingsButton.TabIndex = 8;
            this.UpdateRatingsButton.Text = "Update Customer Ratings";
            this.UpdateRatingsButton.UseVisualStyleBackColor = true;
            this.UpdateRatingsButton.Click += new System.EventHandler(this.UpdateRatingsButton_Click);
            // 
            // FulfillOrderButton
            // 
<<<<<<< HEAD
            this.FulfillOrderButton.Location = new System.Drawing.Point(148, 150);
            this.FulfillOrderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FulfillOrderButton.Name = "FulfillOrderButton";
            this.FulfillOrderButton.Size = new System.Drawing.Size(268, 106);
=======
            this.FulfillOrderButton.Location = new System.Drawing.Point(99, 96);
            this.FulfillOrderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FulfillOrderButton.Name = "FulfillOrderButton";
            this.FulfillOrderButton.Size = new System.Drawing.Size(179, 68);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.FulfillOrderButton.TabIndex = 9;
            this.FulfillOrderButton.Text = "Fulfill order";
            this.FulfillOrderButton.UseVisualStyleBackColor = true;
            this.FulfillOrderButton.Visible = false;
            this.FulfillOrderButton.Click += new System.EventHandler(this.FulfillOrderButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.LogoutButton.Location = new System.Drawing.Point(1750, 54);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(6);
=======
            this.LogoutButton.Location = new System.Drawing.Point(1355, 43);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(150, 44);
            this.LogoutButton.TabIndex = 10;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // OrderMovieButton
            // 
            this.OrderMovieButton.Location = new System.Drawing.Point(148, 150);
            this.OrderMovieButton.Name = "OrderMovieButton";
            this.OrderMovieButton.Size = new System.Drawing.Size(268, 106);
            this.OrderMovieButton.TabIndex = 11;
            this.OrderMovieButton.Text = "Place Order";
            this.OrderMovieButton.UseVisualStyleBackColor = true;
            this.OrderMovieButton.Click += new System.EventHandler(this.OrderMovieButton_Click);
            // 
            // ManagerForm
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.OrderMovieButton);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 686);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.FulfillOrderButton);
            this.Controls.Add(this.UpdateRatingsButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
=======
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerFormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}