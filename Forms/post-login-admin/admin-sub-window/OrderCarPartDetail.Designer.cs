namespace ABCTradersApp.Forms.post_login_admin.admin_controls
{
    partial class OrderCarPartDetail
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
            this.groupBoxOrderInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalAmountLabel = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderDateLabel = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblOrderIDLabel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblLastNameLabel = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblFirstNameLabel = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerIDLabel = new System.Windows.Forms.Label();
            this.groupBoxCarParts = new System.Windows.Forms.GroupBox();
            this.dgvCarParts = new System.Windows.Forms.DataGridView();
            this.groupBoxOrderInfo.SuspendLayout();
            this.groupBoxCustomerInfo.SuspendLayout();
            this.groupBoxCarParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOrderInfo
            // 
            this.groupBoxOrderInfo.Controls.Add(this.lblTotalAmount);
            this.groupBoxOrderInfo.Controls.Add(this.lblTotalAmountLabel);
            this.groupBoxOrderInfo.Controls.Add(this.lblOrderDate);
            this.groupBoxOrderInfo.Controls.Add(this.lblOrderDateLabel);
            this.groupBoxOrderInfo.Controls.Add(this.lblOrderID);
            this.groupBoxOrderInfo.Controls.Add(this.lblOrderIDLabel);
            this.groupBoxOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrderInfo.Location = new System.Drawing.Point(13, 12);
            this.groupBoxOrderInfo.Name = "groupBoxOrderInfo";
            this.groupBoxOrderInfo.Size = new System.Drawing.Size(399, 120);
            this.groupBoxOrderInfo.TabIndex = 1;
            this.groupBoxOrderInfo.TabStop = false;
            this.groupBoxOrderInfo.Text = "Order Information";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(120, 90);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 16);
            this.lblTotalAmount.TabIndex = 5;
            // 
            // lblTotalAmountLabel
            // 
            this.lblTotalAmountLabel.AutoSize = true;
            this.lblTotalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountLabel.Location = new System.Drawing.Point(20, 90);
            this.lblTotalAmountLabel.Name = "lblTotalAmountLabel";
            this.lblTotalAmountLabel.Size = new System.Drawing.Size(89, 16);
            this.lblTotalAmountLabel.TabIndex = 4;
            this.lblTotalAmountLabel.Text = "Total Amount:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(120, 60);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(0, 16);
            this.lblOrderDate.TabIndex = 3;
            // 
            // lblOrderDateLabel
            // 
            this.lblOrderDateLabel.AutoSize = true;
            this.lblOrderDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDateLabel.Location = new System.Drawing.Point(20, 60);
            this.lblOrderDateLabel.Name = "lblOrderDateLabel";
            this.lblOrderDateLabel.Size = new System.Drawing.Size(76, 16);
            this.lblOrderDateLabel.TabIndex = 2;
            this.lblOrderDateLabel.Text = "Order Date:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(120, 30);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(0, 16);
            this.lblOrderID.TabIndex = 1;
            // 
            // lblOrderIDLabel
            // 
            this.lblOrderIDLabel.AutoSize = true;
            this.lblOrderIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIDLabel.Location = new System.Drawing.Point(20, 30);
            this.lblOrderIDLabel.Name = "lblOrderIDLabel";
            this.lblOrderIDLabel.Size = new System.Drawing.Size(60, 16);
            this.lblOrderIDLabel.TabIndex = 0;
            this.lblOrderIDLabel.Text = "Order ID:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(355, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBoxCustomerInfo
            // 
            this.groupBoxCustomerInfo.Controls.Add(this.lblPhone);
            this.groupBoxCustomerInfo.Controls.Add(this.lblPhoneLabel);
            this.groupBoxCustomerInfo.Controls.Add(this.lblEmail);
            this.groupBoxCustomerInfo.Controls.Add(this.lblEmailLabel);
            this.groupBoxCustomerInfo.Controls.Add(this.lblLastName);
            this.groupBoxCustomerInfo.Controls.Add(this.lblLastNameLabel);
            this.groupBoxCustomerInfo.Controls.Add(this.lblFirstName);
            this.groupBoxCustomerInfo.Controls.Add(this.lblFirstNameLabel);
            this.groupBoxCustomerInfo.Controls.Add(this.lblCustomerID);
            this.groupBoxCustomerInfo.Controls.Add(this.lblCustomerIDLabel);
            this.groupBoxCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomerInfo.Location = new System.Drawing.Point(13, 157);
            this.groupBoxCustomerInfo.Name = "groupBoxCustomerInfo";
            this.groupBoxCustomerInfo.Size = new System.Drawing.Size(399, 200);
            this.groupBoxCustomerInfo.TabIndex = 7;
            this.groupBoxCustomerInfo.TabStop = false;
            this.groupBoxCustomerInfo.Text = "Customer Information";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(120, 150);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 16);
            this.lblPhone.TabIndex = 9;
            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneLabel.Location = new System.Drawing.Point(20, 150);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(49, 16);
            this.lblPhoneLabel.TabIndex = 8;
            this.lblPhoneLabel.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(120, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 16);
            this.lblEmail.TabIndex = 7;
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailLabel.Location = new System.Drawing.Point(20, 120);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(44, 16);
            this.lblEmailLabel.TabIndex = 6;
            this.lblEmailLabel.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(120, 90);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(0, 16);
            this.lblLastName.TabIndex = 5;
            // 
            // lblLastNameLabel
            // 
            this.lblLastNameLabel.AutoSize = true;
            this.lblLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameLabel.Location = new System.Drawing.Point(20, 90);
            this.lblLastNameLabel.Name = "lblLastNameLabel";
            this.lblLastNameLabel.Size = new System.Drawing.Size(75, 16);
            this.lblLastNameLabel.TabIndex = 4;
            this.lblLastNameLabel.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(120, 60);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(0, 16);
            this.lblFirstName.TabIndex = 3;
            // 
            // lblFirstNameLabel
            // 
            this.lblFirstNameLabel.AutoSize = true;
            this.lblFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameLabel.Location = new System.Drawing.Point(20, 60);
            this.lblFirstNameLabel.Name = "lblFirstNameLabel";
            this.lblFirstNameLabel.Size = new System.Drawing.Size(75, 16);
            this.lblFirstNameLabel.TabIndex = 2;
            this.lblFirstNameLabel.Text = "First Name:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(120, 30);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(0, 16);
            this.lblCustomerID.TabIndex = 1;
            // 
            // lblCustomerIDLabel
            // 
            this.lblCustomerIDLabel.AutoSize = true;
            this.lblCustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerIDLabel.Location = new System.Drawing.Point(20, 30);
            this.lblCustomerIDLabel.Name = "lblCustomerIDLabel";
            this.lblCustomerIDLabel.Size = new System.Drawing.Size(83, 16);
            this.lblCustomerIDLabel.TabIndex = 0;
            this.lblCustomerIDLabel.Text = "Customer ID:";
            // 
            // groupBoxCarParts
            // 
            this.groupBoxCarParts.Controls.Add(this.dgvCarParts);
            this.groupBoxCarParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCarParts.Location = new System.Drawing.Point(432, 12);
            this.groupBoxCarParts.Name = "groupBoxCarParts";
            this.groupBoxCarParts.Size = new System.Drawing.Size(524, 345);
            this.groupBoxCarParts.TabIndex = 8;
            this.groupBoxCarParts.TabStop = false;
            this.groupBoxCarParts.Text = "Order Car Parts";
            // 
            // dgvCarParts
            // 
            this.dgvCarParts.AllowUserToAddRows = false;
            this.dgvCarParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarParts.Location = new System.Drawing.Point(18, 30);
            this.dgvCarParts.Name = "dgvCarParts";
            this.dgvCarParts.RowHeadersWidth = 51;
            this.dgvCarParts.Size = new System.Drawing.Size(488, 294);
            this.dgvCarParts.TabIndex = 6;
            // 
            // OrderCarPartDetail
            // 
            this.ClientSize = new System.Drawing.Size(968, 452);
            this.Controls.Add(this.groupBoxCarParts);
            this.Controls.Add(this.groupBoxCustomerInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBoxOrderInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OrderCarPartDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Part Details";
            this.groupBoxOrderInfo.ResumeLayout(false);
            this.groupBoxOrderInfo.PerformLayout();
            this.groupBoxCustomerInfo.ResumeLayout(false);
            this.groupBoxCustomerInfo.PerformLayout();
            this.groupBoxCarParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.GroupBox groupBoxCustomerInfo;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblLastNameLabel;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblFirstNameLabel;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerIDLabel;
        private System.Windows.Forms.GroupBox groupBoxCarParts;
        private System.Windows.Forms.DataGridView dgvCarParts;
    }
}