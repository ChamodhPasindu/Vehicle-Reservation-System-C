namespace ABCTradersApp
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewOrderStatus = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnViewCarParts = new System.Windows.Forms.Button();
            this.btnViewCars = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.LightGray;
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnViewOrderStatus);
            this.panelSideMenu.Controls.Add(this.btnOrders);
            this.panelSideMenu.Controls.Add(this.btnViewCarParts);
            this.panelSideMenu.Controls.Add(this.btnViewCars);
            this.panelSideMenu.Controls.Add(this.btnDashboard);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(150, 653);
            this.panelSideMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Location = new System.Drawing.Point(0, 604);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 49);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnViewOrderStatus
            // 
            this.btnViewOrderStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewOrderStatus.Location = new System.Drawing.Point(0, 226);
            this.btnViewOrderStatus.Name = "btnViewOrderStatus";
            this.btnViewOrderStatus.Size = new System.Drawing.Size(150, 58);
            this.btnViewOrderStatus.TabIndex = 5;
            this.btnViewOrderStatus.Text = "View Order";
            this.btnViewOrderStatus.Click += new System.EventHandler(this.BtnViewOrderStatus_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.Location = new System.Drawing.Point(0, 175);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(150, 51);
            this.btnOrders.TabIndex = 4;
            this.btnOrders.Text = "Orders";
            this.btnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // btnViewCarParts
            // 
            this.btnViewCarParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewCarParts.Location = new System.Drawing.Point(0, 118);
            this.btnViewCarParts.Name = "btnViewCarParts";
            this.btnViewCarParts.Size = new System.Drawing.Size(150, 57);
            this.btnViewCarParts.TabIndex = 3;
            this.btnViewCarParts.Text = "View Car Parts";
            this.btnViewCarParts.Click += new System.EventHandler(this.BtnViewCarParts_Click);
            // 
            // btnViewCars
            // 
            this.btnViewCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewCars.Location = new System.Drawing.Point(0, 60);
            this.btnViewCars.Name = "btnViewCars";
            this.btnViewCars.Size = new System.Drawing.Size(150, 58);
            this.btnViewCars.TabIndex = 2;
            this.btnViewCars.Text = "View Cars";
            this.btnViewCars.Click += new System.EventHandler(this.BtnViewCars_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(150, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // panelMainContent
            // 
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(150, 0);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1232, 653);
            this.panelMainContent.TabIndex = 0;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "CustomerForm";
            this.Text = "Customer Dashboard";
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

    }
}