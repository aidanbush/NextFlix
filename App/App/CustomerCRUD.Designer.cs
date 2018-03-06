namespace App
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerRepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet = new App.projectDataSet();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfMoviesRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raiting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 60);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1283, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.customerRepsToolStripMenuItem,
            this.salesReportToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.moviesToolStripMenuItem.Text = "Movies";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // customerRepsToolStripMenuItem
            // 
            this.customerRepsToolStripMenuItem.Name = "customerRepsToolStripMenuItem";
            this.customerRepsToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.customerRepsToolStripMenuItem.Text = "Customer Representatives";
            this.customerRepsToolStripMenuItem.Click += new System.EventHandler(this.customerRepsToolStripMenuItem_Click);
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.first_name,
            this.LastName,
            this.NumberOfMoviesRented,
            this.Raiting,
            this.PhoneNumber,
            this.Email});
            this.dataGridView1.DataSource = this.projectDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(609, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 439);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // projectDataSetBindingSource
            // 
            this.projectDataSetBindingSource.DataSource = this.projectDataSet;
            this.projectDataSetBindingSource.Position = 0;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "projectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "Customer Name";
            this.first_name.Name = "first_name";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "last_name";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // NumberOfMoviesRented
            // 
            this.NumberOfMoviesRented.HeaderText = "Number Of Movies Rented";
            this.NumberOfMoviesRented.Name = "NumberOfMoviesRented";
            // 
            // Raiting
            // 
            this.Raiting.DataPropertyName = "raiting";
            this.Raiting.HeaderText = "Raiting";
            this.Raiting.Name = "Raiting";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "phone_number";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddButton.Location = new System.Drawing.Point(33, 117);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(271, 94);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add Customer";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1283, 653);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerRepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource projectDataSetBindingSource;
        private projectDataSet projectDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfMoviesRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raiting;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button AddButton;
    }
}

