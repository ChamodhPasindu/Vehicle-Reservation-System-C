namespace ABCTradersApp.Forms.post_login_admin.admin_controls
{
    partial class DashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCustomersCount = new System.Windows.Forms.Label();
            this.lblCarsCount = new System.Windows.Forms.Label();
            this.lblCarPartsCount = new System.Windows.Forms.Label();
            this.lblOrdersCount = new System.Windows.Forms.Label();
            this.groupBoxCustomers = new System.Windows.Forms.GroupBox();
            this.groupBoxCars = new System.Windows.Forms.GroupBox();
            this.groupBoxCarParts = new System.Windows.Forms.GroupBox();
            this.groupBoxOrders = new System.Windows.Forms.GroupBox();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.groupBoxCustomers.SuspendLayout();
            this.groupBoxCars.SuspendLayout();
            this.groupBoxCarParts.SuspendLayout();
            this.groupBoxOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomersCount
            // 
            this.lblCustomersCount.AutoSize = true;
            this.lblCustomersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCustomersCount.Location = new System.Drawing.Point(18, 44);
            this.lblCustomersCount.Name = "lblCustomersCount";
            this.lblCustomersCount.Size = new System.Drawing.Size(184, 20);
            this.lblCustomersCount.TabIndex = 0;
            this.lblCustomersCount.Text = "Number of Customers: ";
            // 
            // lblCarsCount
            // 
            this.lblCarsCount.AutoSize = true;
            this.lblCarsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarsCount.Location = new System.Drawing.Point(19, 44);
            this.lblCarsCount.Name = "lblCarsCount";
            this.lblCarsCount.Size = new System.Drawing.Size(138, 20);
            this.lblCarsCount.TabIndex = 1;
            this.lblCarsCount.Text = "Number of Cars: ";
            // 
            // lblCarPartsCount
            // 
            this.lblCarPartsCount.AutoSize = true;
            this.lblCarPartsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarPartsCount.Location = new System.Drawing.Point(18, 49);
            this.lblCarPartsCount.Name = "lblCarPartsCount";
            this.lblCarPartsCount.Size = new System.Drawing.Size(174, 20);
            this.lblCarPartsCount.TabIndex = 2;
            this.lblCarPartsCount.Text = "Number of Car Parts: ";
            // 
            // lblOrdersCount
            // 
            this.lblOrdersCount.AutoSize = true;
            this.lblOrdersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrdersCount.Location = new System.Drawing.Point(19, 49);
            this.lblOrdersCount.Name = "lblOrdersCount";
            this.lblOrdersCount.Size = new System.Drawing.Size(154, 20);
            this.lblOrdersCount.TabIndex = 3;
            this.lblOrdersCount.Text = "Number of Orders: ";
            // 
            // groupBoxCustomers
            // 
            this.groupBoxCustomers.Controls.Add(this.lblCustomersCount);
            this.groupBoxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomers.Location = new System.Drawing.Point(54, 97);
            this.groupBoxCustomers.Name = "groupBoxCustomers";
            this.groupBoxCustomers.Size = new System.Drawing.Size(321, 100);
            this.groupBoxCustomers.TabIndex = 4;
            this.groupBoxCustomers.TabStop = false;
            this.groupBoxCustomers.Text = "Total Customers";
            // 
            // groupBoxCars
            // 
            this.groupBoxCars.Controls.Add(this.lblCarsCount);
            this.groupBoxCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCars.Location = new System.Drawing.Point(501, 97);
            this.groupBoxCars.Name = "groupBoxCars";
            this.groupBoxCars.Size = new System.Drawing.Size(327, 100);
            this.groupBoxCars.TabIndex = 5;
            this.groupBoxCars.TabStop = false;
            this.groupBoxCars.Text = "Total Cars";
            // 
            // groupBoxCarParts
            // 
            this.groupBoxCarParts.Controls.Add(this.lblCarPartsCount);
            this.groupBoxCarParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCarParts.Location = new System.Drawing.Point(54, 232);
            this.groupBoxCarParts.Name = "groupBoxCarParts";
            this.groupBoxCarParts.Size = new System.Drawing.Size(321, 100);
            this.groupBoxCarParts.TabIndex = 6;
            this.groupBoxCarParts.TabStop = false;
            this.groupBoxCarParts.Text = "Total Car Parts";
            // 
            // groupBoxOrders
            // 
            this.groupBoxOrders.Controls.Add(this.lblOrdersCount);
            this.groupBoxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrders.Location = new System.Drawing.Point(501, 232);
            this.groupBoxOrders.Name = "groupBoxOrders";
            this.groupBoxOrders.Size = new System.Drawing.Size(327, 100);
            this.groupBoxOrders.TabIndex = 7;
            this.groupBoxOrders.TabStop = false;
            this.groupBoxOrders.Text = "Total Orders";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(61, 24);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(145, 29);
            this.lblDashboard.TabIndex = 8;
            this.lblDashboard.Text = "Dashboard";
            // 
            // DashboardControl
            // 
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.groupBoxOrders);
            this.Controls.Add(this.groupBoxCarParts);
            this.Controls.Add(this.groupBoxCars);
            this.Controls.Add(this.groupBoxCustomers);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(900, 525);
            this.groupBoxCustomers.ResumeLayout(false);
            this.groupBoxCustomers.PerformLayout();
            this.groupBoxCars.ResumeLayout(false);
            this.groupBoxCars.PerformLayout();
            this.groupBoxCarParts.ResumeLayout(false);
            this.groupBoxCarParts.PerformLayout();
            this.groupBoxOrders.ResumeLayout(false);
            this.groupBoxOrders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblDashboard;
    }
}
