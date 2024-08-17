namespace ABCTradersApp.Forms.post_login_customer.customer_controls
{
    partial class ViewCarDetail
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxCarDetails = new System.Windows.Forms.GroupBox();
            this.lblDescriptionValue = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblYearValue = new System.Windows.Forms.Label();
            this.lblManufacturerValue = new System.Windows.Forms.Label();
            this.lblModelValue = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.groupBoxCarDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(220, 300);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(70, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupBoxCarDetails
            // 
            this.groupBoxCarDetails.Controls.Add(this.lblDescriptionValue);
            this.groupBoxCarDetails.Controls.Add(this.lblPriceValue);
            this.groupBoxCarDetails.Controls.Add(this.lblYearValue);
            this.groupBoxCarDetails.Controls.Add(this.lblManufacturerValue);
            this.groupBoxCarDetails.Controls.Add(this.lblModelValue);
            this.groupBoxCarDetails.Controls.Add(this.lblDescription);
            this.groupBoxCarDetails.Controls.Add(this.lblPrice);
            this.groupBoxCarDetails.Controls.Add(this.lblYear);
            this.groupBoxCarDetails.Controls.Add(this.lblManufacturer);
            this.groupBoxCarDetails.Controls.Add(this.lblModel);
            this.groupBoxCarDetails.Location = new System.Drawing.Point(34, 23);
            this.groupBoxCarDetails.Name = "groupBoxCarDetails";
            this.groupBoxCarDetails.Size = new System.Drawing.Size(325, 254);
            this.groupBoxCarDetails.TabIndex = 12;
            this.groupBoxCarDetails.TabStop = false;
            this.groupBoxCarDetails.Text = "Car Details";
            // 
            // lblDescriptionValue
            // 
            this.lblDescriptionValue.AutoSize = true;
            this.lblDescriptionValue.Location = new System.Drawing.Point(183, 200);
            this.lblDescriptionValue.Name = "lblDescriptionValue";
            this.lblDescriptionValue.Size = new System.Drawing.Size(50, 16);
            this.lblDescriptionValue.TabIndex = 19;
            this.lblDescriptionValue.Text = "[Value]";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Location = new System.Drawing.Point(183, 160);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(50, 16);
            this.lblPriceValue.TabIndex = 18;
            this.lblPriceValue.Text = "[Value]";
            // 
            // lblYearValue
            // 
            this.lblYearValue.AutoSize = true;
            this.lblYearValue.Location = new System.Drawing.Point(183, 120);
            this.lblYearValue.Name = "lblYearValue";
            this.lblYearValue.Size = new System.Drawing.Size(50, 16);
            this.lblYearValue.TabIndex = 17;
            this.lblYearValue.Text = "[Value]";
            // 
            // lblManufacturerValue
            // 
            this.lblManufacturerValue.AutoSize = true;
            this.lblManufacturerValue.Location = new System.Drawing.Point(183, 80);
            this.lblManufacturerValue.Name = "lblManufacturerValue";
            this.lblManufacturerValue.Size = new System.Drawing.Size(50, 16);
            this.lblManufacturerValue.TabIndex = 16;
            this.lblManufacturerValue.Text = "[Value]";
            // 
            // lblModelValue
            // 
            this.lblModelValue.AutoSize = true;
            this.lblModelValue.Location = new System.Drawing.Point(183, 40);
            this.lblModelValue.Name = "lblModelValue";
            this.lblModelValue.Size = new System.Drawing.Size(50, 16);
            this.lblModelValue.TabIndex = 15;
            this.lblModelValue.Text = "[Value]";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(63, 200);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 16);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(63, 160);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(63, 120);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 16);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Year:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(63, 80);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(87, 16);
            this.lblManufacturer.TabIndex = 11;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(63, 40);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(48, 16);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Model:";
            // 
            // ViewCarDetail
            // 
            this.ClientSize = new System.Drawing.Size(427, 363);
            this.Controls.Add(this.groupBoxCarDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrder);
            this.Name = "ViewCarDetail";
            this.Text = "Car Detail";
            this.groupBoxCarDetails.ResumeLayout(false);
            this.groupBoxCarDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCarDetails;
        private System.Windows.Forms.Label lblDescriptionValue;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblYearValue;
        private System.Windows.Forms.Label lblManufacturerValue;
        private System.Windows.Forms.Label lblModelValue;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblModel;
    }
}