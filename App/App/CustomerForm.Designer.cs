﻿namespace App
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
            this.NumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1147, 40);
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
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // movieHomeToolStripMenuItem
            // 
            this.movieHomeToolStripMenuItem.Name = "movieHomeToolStripMenuItem";
            this.movieHomeToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
            this.movieHomeToolStripMenuItem.Text = "Movie";
            this.movieHomeToolStripMenuItem.Click += new System.EventHandler(this.movieHomeToolStripMenuItem_Click);
            // 
            // myMoviesToolStripMenuItem
            // 
            this.myMoviesToolStripMenuItem.Name = "myMoviesToolStripMenuItem";
            this.myMoviesToolStripMenuItem.Size = new System.Drawing.Size(232, 38);
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
            this.ProfilePanel.Controls.Add(this.NumberLabel);
            this.ProfilePanel.Controls.Add(this.label2);
            this.ProfilePanel.Controls.Add(this.EditButton);
            this.ProfilePanel.Controls.Add(this.EmailLabel);
            this.ProfilePanel.Controls.Add(this.PhoneLabel);
            this.ProfilePanel.Controls.Add(this.StateLabel);
            this.ProfilePanel.Controls.Add(this.CityLabel);
            this.ProfilePanel.Controls.Add(this.AddressLabel);
            this.ProfilePanel.Controls.Add(this.NameLabel);
            this.ProfilePanel.Controls.Add(this.label1);
            this.ProfilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfilePanel.Location = new System.Drawing.Point(0, 40);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(1147, 667);
            this.ProfilePanel.TabIndex = 1;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(41, 449);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(87, 25);
            this.NumberLabel.TabIndex = 9;
            this.NumberLabel.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Payment Information:";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(41, 303);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(224, 52);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Edit Information";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(41, 249);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(71, 25);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(41, 202);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(80, 25);
            this.PhoneLabel.TabIndex = 5;
            this.PhoneLabel.Text = "Phone:";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(141, 157);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(68, 25);
            this.StateLabel.TabIndex = 4;
            this.StateLabel.Text = "State:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(41, 157);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(55, 25);
            this.CityLabel.TabIndex = 3;
            this.CityLabel.Text = "City:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(41, 118);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(103, 25);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(41, 77);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Information:";
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.label3);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 40);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1147, 667);
            this.HomePanel.TabIndex = 10;
            this.HomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomePanel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hello, User";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 707);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.ProfilePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustomerForm";
            this.Text = "Grettings, User";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
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
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HomePanel;
        public System.Windows.Forms.Label label3;
    }
}