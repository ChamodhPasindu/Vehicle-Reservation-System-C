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
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dgvCarParts = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStaticOrderID = new System.Windows.Forms.Label();
            this.lblStaticOrderDate = new System.Windows.Forms.Label();
            this.lblStaticAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(119, 28);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(0, 16);
            this.lblOrderId.TabIndex = 0;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(119, 68);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(0, 16);
            this.lblOrderDate.TabIndex = 1;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(119, 108);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 16);
            this.lblTotalAmount.TabIndex = 2;
            // 
            // dgvCarParts
            // 
            this.dgvCarParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarParts.Location = new System.Drawing.Point(20, 150);
            this.dgvCarParts.Name = "dgvCarParts";
            this.dgvCarParts.RowHeadersWidth = 51;
            this.dgvCarParts.Size = new System.Drawing.Size(750, 300);
            this.dgvCarParts.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(350, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblStaticOrderID
            // 
            this.lblStaticOrderID.AutoSize = true;
            this.lblStaticOrderID.Location = new System.Drawing.Point(20, 27);
            this.lblStaticOrderID.Name = "lblStaticOrderID";
            this.lblStaticOrderID.Size = new System.Drawing.Size(60, 16);
            this.lblStaticOrderID.TabIndex = 5;
            this.lblStaticOrderID.Text = "Order ID:";
            // 
            // lblStaticOrderDate
            // 
            this.lblStaticOrderDate.AutoSize = true;
            this.lblStaticOrderDate.Location = new System.Drawing.Point(20, 68);
            this.lblStaticOrderDate.Name = "lblStaticOrderDate";
            this.lblStaticOrderDate.Size = new System.Drawing.Size(76, 16);
            this.lblStaticOrderDate.TabIndex = 6;
            this.lblStaticOrderDate.Text = "Order Date:";
            // 
            // lblStaticAmount
            // 
            this.lblStaticAmount.AutoSize = true;
            this.lblStaticAmount.Location = new System.Drawing.Point(20, 108);
            this.lblStaticAmount.Name = "lblStaticAmount";
            this.lblStaticAmount.Size = new System.Drawing.Size(89, 16);
            this.lblStaticAmount.TabIndex = 7;
            this.lblStaticAmount.Text = "Total Amount:";
            // 
            // OrderCarPartDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.lblStaticAmount);
            this.Controls.Add(this.lblStaticOrderDate);
            this.Controls.Add(this.lblStaticOrderID);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.dgvCarParts);
            this.Controls.Add(this.btnClose);
            this.Name = "OrderCarPartDetail";
            this.Text = "Order Car Part Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaticOrderID;
        private System.Windows.Forms.Label lblStaticOrderDate;
        private System.Windows.Forms.Label lblStaticAmount;
    }
}