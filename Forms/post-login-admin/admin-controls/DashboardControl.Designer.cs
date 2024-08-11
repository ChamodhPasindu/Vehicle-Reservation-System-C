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
            this.SuspendLayout();
            // 
            // lblCustomersCount
            // 
            this.lblCustomersCount.AutoSize = true;
            this.lblCustomersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCustomersCount.Location = new System.Drawing.Point(30, 30);
            this.lblCustomersCount.Name = "lblCustomersCount";
            this.lblCustomersCount.Size = new System.Drawing.Size(184, 20);
            this.lblCustomersCount.TabIndex = 0;
            this.lblCustomersCount.Text = "Number of Customers: ";
            // 
            // lblCarsCount
            // 
            this.lblCarsCount.AutoSize = true;
            this.lblCarsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarsCount.Location = new System.Drawing.Point(622, 30);
            this.lblCarsCount.Name = "lblCarsCount";
            this.lblCarsCount.Size = new System.Drawing.Size(138, 20);
            this.lblCarsCount.TabIndex = 1;
            this.lblCarsCount.Text = "Number of Cars: ";
            // 
            // lblCarPartsCount
            // 
            this.lblCarPartsCount.AutoSize = true;
            this.lblCarPartsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarPartsCount.Location = new System.Drawing.Point(30, 110);
            this.lblCarPartsCount.Name = "lblCarPartsCount";
            this.lblCarPartsCount.Size = new System.Drawing.Size(174, 20);
            this.lblCarPartsCount.TabIndex = 2;
            this.lblCarPartsCount.Text = "Number of Car Parts: ";
            // 
            // lblOrdersCount
            // 
            this.lblOrdersCount.AutoSize = true;
            this.lblOrdersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrdersCount.Location = new System.Drawing.Point(622, 110);
            this.lblOrdersCount.Name = "lblOrdersCount";
            this.lblOrdersCount.Size = new System.Drawing.Size(154, 20);
            this.lblOrdersCount.TabIndex = 3;
            this.lblOrdersCount.Text = "Number of Orders: ";
            // 
            // DashboardControl
            // 
            this.Controls.Add(this.lblCustomersCount);
            this.Controls.Add(this.lblCarsCount);
            this.Controls.Add(this.lblCarPartsCount);
            this.Controls.Add(this.lblOrdersCount);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(901, 526);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
