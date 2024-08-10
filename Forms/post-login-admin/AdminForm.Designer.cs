using System;

namespace ABCTradersApp
{
    partial class AdminForm
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnCarParts = new System.Windows.Forms.Button();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.LightGray;
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnReports);
            this.panelSideMenu.Controls.Add(this.btnOrders);
            this.panelSideMenu.Controls.Add(this.btnCustomers);
            this.panelSideMenu.Controls.Add(this.btnCarParts);
            this.panelSideMenu.Controls.Add(this.btnCars);
            this.panelSideMenu.Controls.Add(this.btnDashboard); // Add Dashboard button to panel
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(150, 639);
            this.panelSideMenu.TabIndex = 1;

            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(150, 60);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);

            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Location = new System.Drawing.Point(0, 590);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 49);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.Location = new System.Drawing.Point(0, 226);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(150, 58);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.Location = new System.Drawing.Point(0, 175);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(150, 51);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Orders";
            this.btnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.Location = new System.Drawing.Point(0, 118);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(150, 57);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // btnCarParts
            // 
            this.btnCarParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCarParts.Location = new System.Drawing.Point(0, 60);
            this.btnCarParts.Name = "btnCarParts";
            this.btnCarParts.Size = new System.Drawing.Size(150, 58);
            this.btnCarParts.TabIndex = 4;
            this.btnCarParts.Text = "Car Parts";
            this.btnCarParts.Click += new System.EventHandler(this.BtnCarParts_Click);
            // 
            // panelMainContent
            // 
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(150, 0);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(997, 639);
            this.panelMainContent.TabIndex = 0;
            // 
            // btnCars
            // 
            this.btnCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCars.Location = new System.Drawing.Point(0, 0);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(150, 60);
            this.btnCars.TabIndex = 5;
            this.btnCars.Text = "Cars";
            this.btnCars.Click += new System.EventHandler(this.BtnCars_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 639);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "AdminForm";
            this.Text = "Admin Dashboard";
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}