namespace ABCTradersApp.Forms.post_login_customer.customer_controls
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
            this.lblTotalCarParts = new System.Windows.Forms.Label();
            this.lblTotalCars = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalCarPartsValue = new System.Windows.Forms.Label();
            this.lblTotalCarsValue = new System.Windows.Forms.Label();
            this.lblTotalOrdersValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalCarParts
            // 
            this.lblTotalCarParts.AutoSize = true;
            this.lblTotalCarParts.Location = new System.Drawing.Point(30, 30);
            this.lblTotalCarParts.Name = "lblTotalCarParts";
            this.lblTotalCarParts.Size = new System.Drawing.Size(99, 16);
            this.lblTotalCarParts.TabIndex = 0;
            this.lblTotalCarParts.Text = "Total Car Parts:";
            // 
            // lblTotalCars
            // 
            this.lblTotalCars.AutoSize = true;
            this.lblTotalCars.Location = new System.Drawing.Point(401, 30);
            this.lblTotalCars.Name = "lblTotalCars";
            this.lblTotalCars.Size = new System.Drawing.Size(72, 16);
            this.lblTotalCars.TabIndex = 1;
            this.lblTotalCars.Text = "Total Cars:";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Location = new System.Drawing.Point(30, 110);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(85, 16);
            this.lblTotalOrders.TabIndex = 2;
            this.lblTotalOrders.Text = "Total Orders:";
            // 
            // lblTotalCarPartsValue
            // 
            this.lblTotalCarPartsValue.AutoSize = true;
            this.lblTotalCarPartsValue.Location = new System.Drawing.Point(150, 30);
            this.lblTotalCarPartsValue.Name = "lblTotalCarPartsValue";
            this.lblTotalCarPartsValue.Size = new System.Drawing.Size(0, 16);
            this.lblTotalCarPartsValue.TabIndex = 3;
            // 
            // lblTotalCarsValue
            // 
            this.lblTotalCarsValue.AutoSize = true;
            this.lblTotalCarsValue.Location = new System.Drawing.Point(501, 30);
            this.lblTotalCarsValue.Name = "lblTotalCarsValue";
            this.lblTotalCarsValue.Size = new System.Drawing.Size(0, 16);
            this.lblTotalCarsValue.TabIndex = 4;
            // 
            // lblTotalOrdersValue
            // 
            this.lblTotalOrdersValue.AutoSize = true;
            this.lblTotalOrdersValue.Location = new System.Drawing.Point(150, 110);
            this.lblTotalOrdersValue.Name = "lblTotalOrdersValue";
            this.lblTotalOrdersValue.Size = new System.Drawing.Size(0, 16);
            this.lblTotalOrdersValue.TabIndex = 5;
            // 
            // DashboardControl
            // 
            this.Controls.Add(this.lblTotalOrdersValue);
            this.Controls.Add(this.lblTotalCarsValue);
            this.Controls.Add(this.lblTotalCarPartsValue);
            this.Controls.Add(this.lblTotalOrders);
            this.Controls.Add(this.lblTotalCars);
            this.Controls.Add(this.lblTotalCarParts);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(901, 526);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
