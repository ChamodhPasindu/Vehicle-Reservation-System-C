namespace ABCTradersApp.Forms.post_login_customer.customer_controls
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
            this.dgvCarParts = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxOrderDetails = new System.Windows.Forms.GroupBox();
            this.lblStaticAmount = new System.Windows.Forms.Label();
            this.lblStaticOrderDate = new System.Windows.Forms.Label();
            this.lblStaticOrderID = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).BeginInit();
            this.groupBoxOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCarParts
            // 
            this.dgvCarParts.AllowUserToAddRows = false;
            this.dgvCarParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarParts.Location = new System.Drawing.Point(20, 184);
            this.dgvCarParts.Name = "dgvCarParts";
            this.dgvCarParts.RowHeadersWidth = 51;
            this.dgvCarParts.Size = new System.Drawing.Size(750, 278);
            this.dgvCarParts.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(350, 478);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBoxOrderDetails
            // 
            this.groupBoxOrderDetails.Controls.Add(this.lblStaticAmount);
            this.groupBoxOrderDetails.Controls.Add(this.lblStaticOrderDate);
            this.groupBoxOrderDetails.Controls.Add(this.lblStaticOrderID);
            this.groupBoxOrderDetails.Controls.Add(this.lblOrderId);
            this.groupBoxOrderDetails.Controls.Add(this.lblOrderDate);
            this.groupBoxOrderDetails.Controls.Add(this.lblTotalAmount);
            this.groupBoxOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrderDetails.Location = new System.Drawing.Point(20, 12);
            this.groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            this.groupBoxOrderDetails.Size = new System.Drawing.Size(405, 147);
            this.groupBoxOrderDetails.TabIndex = 8;
            this.groupBoxOrderDetails.TabStop = false;
            this.groupBoxOrderDetails.Text = "Order Details";
            // 
            // lblStaticAmount
            // 
            this.lblStaticAmount.AutoSize = true;
            this.lblStaticAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticAmount.Location = new System.Drawing.Point(26, 113);
            this.lblStaticAmount.Name = "lblStaticAmount";
            this.lblStaticAmount.Size = new System.Drawing.Size(89, 16);
            this.lblStaticAmount.TabIndex = 13;
            this.lblStaticAmount.Text = "Total Amount:";
            // 
            // lblStaticOrderDate
            // 
            this.lblStaticOrderDate.AutoSize = true;
            this.lblStaticOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticOrderDate.Location = new System.Drawing.Point(26, 73);
            this.lblStaticOrderDate.Name = "lblStaticOrderDate";
            this.lblStaticOrderDate.Size = new System.Drawing.Size(76, 16);
            this.lblStaticOrderDate.TabIndex = 12;
            this.lblStaticOrderDate.Text = "Order Date:";
            // 
            // lblStaticOrderID
            // 
            this.lblStaticOrderID.AutoSize = true;
            this.lblStaticOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticOrderID.Location = new System.Drawing.Point(26, 32);
            this.lblStaticOrderID.Name = "lblStaticOrderID";
            this.lblStaticOrderID.Size = new System.Drawing.Size(60, 16);
            this.lblStaticOrderID.TabIndex = 11;
            this.lblStaticOrderID.Text = "Order ID:";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(125, 33);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(0, 16);
            this.lblOrderId.TabIndex = 8;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(125, 73);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(0, 16);
            this.lblOrderDate.TabIndex = 9;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(125, 113);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 16);
            this.lblTotalAmount.TabIndex = 10;
            // 
            // OrderCarPartDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.groupBoxOrderDetails);
            this.Controls.Add(this.dgvCarParts);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OrderCarPartDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Car Part Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).EndInit();
            this.groupBoxOrderDetails.ResumeLayout(false);
            this.groupBoxOrderDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
       
    }
}