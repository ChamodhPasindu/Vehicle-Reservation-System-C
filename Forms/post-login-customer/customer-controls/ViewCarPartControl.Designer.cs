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
            this.btnOrder = new System.Windows.Forms.Button();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.PartNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblStaticPartNo = new System.Windows.Forms.Label();
            this.lblStaticPrice = new System.Windows.Forms.Label();
            this.lblStaticDescription = new System.Windows.Forms.Label();
            this.lblStaticQty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPartName
            // 
            this.cmbPartName.FormattingEnabled = true;
            this.cmbPartName.Location = new System.Drawing.Point(68, 12);
            this.cmbPartName.Name = "cmbPartName";
            this.cmbPartName.Size = new System.Drawing.Size(200, 24);
            this.cmbPartName.TabIndex = 0;
            this.cmbPartName.SelectedIndexChanged += new System.EventHandler(this.CmbPartName_SelectedIndexChanged);
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Location = new System.Drawing.Point(225, 49);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(0, 16);
            this.lblPartNumber.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(225, 85);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 16);
            this.lblPrice.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(225, 117);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 16);
            this.lblDescription.TabIndex = 3;
            // 
            // lblAvailableQuantity
            // 
            this.lblAvailableQuantity.AutoSize = true;
            this.lblAvailableQuantity.Location = new System.Drawing.Point(225, 151);
            this.lblAvailableQuantity.Name = "lblAvailableQuantity";
            this.lblAvailableQuantity.Size = new System.Drawing.Size(0, 16);
            this.lblAvailableQuantity.TabIndex = 4;
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Location = new System.Drawing.Point(68, 194);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtOrderQuantity.TabIndex = 5;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(174, 192);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(94, 23);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(553, 444);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(200, 23);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // cartGridView
            // 
            this.cartGridView.AllowUserToAddRows = false;
            this.cartGridView.AllowUserToDeleteRows = false;
            this.cartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartNameColumn,
            this.PartNumberColumn,
            this.QuantityColumn,
            this.PriceColumn,
            this.TotalColumn});
            this.cartGridView.Location = new System.Drawing.Point(68, 261);
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.ReadOnly = true;
            this.cartGridView.RowHeadersWidth = 51;
            this.cartGridView.Size = new System.Drawing.Size(716, 150);
            this.cartGridView.TabIndex = 8;
            // 
            // PartNameColumn
            // 
            this.PartNameColumn.HeaderText = "Part Name";
            this.PartNameColumn.MinimumWidth = 6;
            this.PartNameColumn.Name = "PartName";
            this.PartNameColumn.ReadOnly = true;
            // 
            // PartNumberColumn
            // 
            this.PartNumberColumn.HeaderText = "Part Number";
            this.PartNumberColumn.MinimumWidth = 6;
            this.PartNumberColumn.Name = "PartNumber";
            this.PartNumberColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.MinimumWidth = 6;
            this.QuantityColumn.Name = "Quantity";
            this.QuantityColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "Price";
            this.PriceColumn.ReadOnly = true;
            // 
            // TotalColumn
            // 
            this.TotalColumn.HeaderText = "Total";
            this.TotalColumn.MinimumWidth = 6;
            this.TotalColumn.Name = "TotalColumn";
            this.TotalColumn.ReadOnly = true;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(132, 447);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(14, 16);
            this.lblTotalValue.TabIndex = 10;
            this.lblTotalValue.Text = "0";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Location = new System.Drawing.Point(73, 447);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(41, 16);
            this.lblTotalLabel.TabIndex = 9;
            this.lblTotalLabel.Text = "Total:";
            // 
            // lblStaticPartNo
            // 
            this.lblStaticPartNo.AutoSize = true;
            this.lblStaticPartNo.Location = new System.Drawing.Point(68, 49);
            this.lblStaticPartNo.Name = "lblStaticPartNo";
            this.lblStaticPartNo.Size = new System.Drawing.Size(85, 16);
            this.lblStaticPartNo.TabIndex = 11;
            this.lblStaticPartNo.Text = "Part Number:";
            // 
            // lblStaticPrice
            // 
            this.lblStaticPrice.AutoSize = true;
            this.lblStaticPrice.Location = new System.Drawing.Point(69, 84);
            this.lblStaticPrice.Name = "lblStaticPrice";
            this.lblStaticPrice.Size = new System.Drawing.Size(41, 16);
            this.lblStaticPrice.TabIndex = 12;
            this.lblStaticPrice.Text = "Price:";
            // 
            // lblStaticDescription
            // 
            this.lblStaticDescription.AutoSize = true;
            this.lblStaticDescription.Location = new System.Drawing.Point(68, 116);
            this.lblStaticDescription.Name = "lblStaticDescription";
            this.lblStaticDescription.Size = new System.Drawing.Size(78, 16);
            this.lblStaticDescription.TabIndex = 13;
            this.lblStaticDescription.Text = "Description:";
            // 
            // lblStaticQty
            // 
            this.lblStaticQty.AutoSize = true;
            this.lblStaticQty.Location = new System.Drawing.Point(69, 150);
            this.lblStaticQty.Name = "lblStaticQty";
            this.lblStaticQty.Size = new System.Drawing.Size(118, 16);
            this.lblStaticQty.TabIndex = 14;
            this.lblStaticQty.Text = "Available Quantity:";
            // 
            // ViewCarPartControl
            // 
            this.Controls.Add(this.lblStaticQty);
            this.Controls.Add(this.lblStaticDescription);
            this.Controls.Add(this.lblStaticPrice);
            this.Controls.Add(this.lblStaticPartNo);
            this.Controls.Add(this.lblTotalLabel);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.cartGridView);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txtOrderQuantity);
            this.Controls.Add(this.lblAvailableQuantity);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPartNumber);
            this.Controls.Add(this.cmbPartName);
            this.Name = "ViewCarPartControl";
            this.Size = new System.Drawing.Size(850, 500);
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStaticPartNo;
        private Label lblStaticPrice;
        private Label lblStaticDescription;
        private Label lblStaticQty;
    }
}
