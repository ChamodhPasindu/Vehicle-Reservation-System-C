using System.Windows.Forms;

namespace ABCTradersApp.Forms.post_login_customer.customer_controls
{
    partial class ViewCarPartControl
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
            this.cmbPartName = new System.Windows.Forms.ComboBox();
            this.lblPartNumber = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAvailableQuantity = new System.Windows.Forms.Label();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblStaticPartNo = new System.Windows.Forms.Label();
            this.lblStaticPrice = new System.Windows.Forms.Label();
            this.lblStaticDescription = new System.Windows.Forms.Label();
            this.lblStaticQty = new System.Windows.Forms.Label();
            this.groupBoxOrderDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxCarParts = new System.Windows.Forms.GroupBox();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblStaticQuantity = new System.Windows.Forms.Label();
            this.groupBoxOrderDetails.SuspendLayout();
            this.groupBoxCarParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPartName
            // 
            this.cmbPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPartName.FormattingEnabled = true;
            this.cmbPartName.Location = new System.Drawing.Point(29, 28);
            this.cmbPartName.Name = "cmbPartName";
            this.cmbPartName.Size = new System.Drawing.Size(200, 24);
            this.cmbPartName.TabIndex = 0;
            this.cmbPartName.SelectedIndexChanged += new System.EventHandler(this.CmbPartName_SelectedIndexChanged);
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartNumber.Location = new System.Drawing.Point(433, 36);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(0, 16);
            this.lblPartNumber.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(433, 72);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 16);
            this.lblPrice.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(433, 106);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 16);
            this.lblDescription.TabIndex = 3;
            // 
            // lblAvailableQuantity
            // 
            this.lblAvailableQuantity.AutoSize = true;
            this.lblAvailableQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableQuantity.Location = new System.Drawing.Point(433, 140);
            this.lblAvailableQuantity.Name = "lblAvailableQuantity";
            this.lblAvailableQuantity.Size = new System.Drawing.Size(0, 16);
            this.lblAvailableQuantity.TabIndex = 4;
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderQuantity.Location = new System.Drawing.Point(436, 171);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtOrderQuantity.TabIndex = 5;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(678, 174);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(94, 23);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // lblStaticPartNo
            // 
            this.lblStaticPartNo.AutoSize = true;
            this.lblStaticPartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticPartNo.Location = new System.Drawing.Point(276, 36);
            this.lblStaticPartNo.Name = "lblStaticPartNo";
            this.lblStaticPartNo.Size = new System.Drawing.Size(85, 16);
            this.lblStaticPartNo.TabIndex = 11;
            this.lblStaticPartNo.Text = "Part Number:";
            // 
            // lblStaticPrice
            // 
            this.lblStaticPrice.AutoSize = true;
            this.lblStaticPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticPrice.Location = new System.Drawing.Point(277, 71);
            this.lblStaticPrice.Name = "lblStaticPrice";
            this.lblStaticPrice.Size = new System.Drawing.Size(41, 16);
            this.lblStaticPrice.TabIndex = 12;
            this.lblStaticPrice.Text = "Price:";
            // 
            // lblStaticDescription
            // 
            this.lblStaticDescription.AutoSize = true;
            this.lblStaticDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticDescription.Location = new System.Drawing.Point(276, 106);
            this.lblStaticDescription.Name = "lblStaticDescription";
            this.lblStaticDescription.Size = new System.Drawing.Size(78, 16);
            this.lblStaticDescription.TabIndex = 13;
            this.lblStaticDescription.Text = "Description:";
            // 
            // lblStaticQty
            // 
            this.lblStaticQty.AutoSize = true;
            this.lblStaticQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticQty.Location = new System.Drawing.Point(277, 140);
            this.lblStaticQty.Name = "lblStaticQty";
            this.lblStaticQty.Size = new System.Drawing.Size(118, 16);
            this.lblStaticQty.TabIndex = 14;
            this.lblStaticQty.Text = "Available Quantity:";
            // 
            // groupBoxOrderDetails
            // 
            this.groupBoxOrderDetails.Controls.Add(this.lblStaticQuantity);
            this.groupBoxOrderDetails.Controls.Add(this.cmbPartName);
            this.groupBoxOrderDetails.Controls.Add(this.lblStaticQty);
            this.groupBoxOrderDetails.Controls.Add(this.lblPartNumber);
            this.groupBoxOrderDetails.Controls.Add(this.lblStaticDescription);
            this.groupBoxOrderDetails.Controls.Add(this.lblPrice);
            this.groupBoxOrderDetails.Controls.Add(this.lblStaticPrice);
            this.groupBoxOrderDetails.Controls.Add(this.lblDescription);
            this.groupBoxOrderDetails.Controls.Add(this.lblStaticPartNo);
            this.groupBoxOrderDetails.Controls.Add(this.lblAvailableQuantity);
            this.groupBoxOrderDetails.Controls.Add(this.txtOrderQuantity);
            this.groupBoxOrderDetails.Controls.Add(this.btnAddToCart);
            this.groupBoxOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrderDetails.Location = new System.Drawing.Point(58, 74);
            this.groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            this.groupBoxOrderDetails.Size = new System.Drawing.Size(795, 208);
            this.groupBoxOrderDetails.TabIndex = 15;
            this.groupBoxOrderDetails.TabStop = false;
            this.groupBoxOrderDetails.Text = "Order Details";
            // 
            // groupBoxCarParts
            // 
            this.groupBoxCarParts.Controls.Add(this.lblTotalLabel);
            this.groupBoxCarParts.Controls.Add(this.lblTotalValue);
            this.groupBoxCarParts.Controls.Add(this.cartGridView);
            this.groupBoxCarParts.Controls.Add(this.btnOrder);
            this.groupBoxCarParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCarParts.Location = new System.Drawing.Point(58, 288);
            this.groupBoxCarParts.Name = "groupBoxCarParts";
            this.groupBoxCarParts.Size = new System.Drawing.Size(795, 216);
            this.groupBoxCarParts.TabIndex = 15;
            this.groupBoxCarParts.TabStop = false;
            this.groupBoxCarParts.Text = "Car Parts";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Location = new System.Drawing.Point(19, 188);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(41, 16);
            this.lblTotalLabel.TabIndex = 13;
            this.lblTotalLabel.Text = "Total:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(78, 188);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(14, 16);
            this.lblTotalValue.TabIndex = 14;
            this.lblTotalValue.Text = "0";
            // 
            // cartGridView
            // 
            this.cartGridView.AllowUserToAddRows = false;
            this.cartGridView.AllowUserToDeleteRows = false;
            this.cartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartName,
            this.PartNumber,
            this.Quantity,
            this.Price,
            this.TotalColumn});
            this.cartGridView.Location = new System.Drawing.Point(14, 26);
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.ReadOnly = true;
            this.cartGridView.RowHeadersWidth = 51;
            this.cartGridView.Size = new System.Drawing.Size(758, 150);
            this.cartGridView.TabIndex = 12;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "Part Name";
            this.PartName.MinimumWidth = 6;
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // PartNumber
            // 
            this.PartNumber.HeaderText = "Part Number";
            this.PartNumber.MinimumWidth = 6;
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // TotalColumn
            // 
            this.TotalColumn.HeaderText = "Total";
            this.TotalColumn.MinimumWidth = 6;
            this.TotalColumn.Name = "TotalColumn";
            this.TotalColumn.ReadOnly = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(572, 185);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(200, 23);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(53, 14);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(222, 29);
            this.lblOrder.TabIndex = 16;
            this.lblOrder.Text = "Place Your Order";
            // 
            // lblStaticQuantity
            // 
            this.lblStaticQuantity.AutoSize = true;
            this.lblStaticQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticQuantity.Location = new System.Drawing.Point(277, 174);
            this.lblStaticQuantity.Name = "lblStaticQuantity";
            this.lblStaticQuantity.Size = new System.Drawing.Size(58, 16);
            this.lblStaticQuantity.TabIndex = 15;
            this.lblStaticQuantity.Text = "Quantity:";
            // 
            // ViewCarPartControl
            // 
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.groupBoxCarParts);
            this.Controls.Add(this.groupBoxOrderDetails);
            this.Name = "ViewCarPartControl";
            this.Size = new System.Drawing.Size(900, 525);
            this.groupBoxOrderDetails.ResumeLayout(false);
            this.groupBoxOrderDetails.PerformLayout();
            this.groupBoxCarParts.ResumeLayout(false);
            this.groupBoxCarParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label lblOrder;
        private Label lblStaticQuantity;
    }
}
