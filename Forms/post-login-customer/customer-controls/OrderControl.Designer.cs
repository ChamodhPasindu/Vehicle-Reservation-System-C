namespace ABCTradersApp.Forms.post_login_customer.customer_controls
{
    partial class OrderControl
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
            this.grpCarOrders = new System.Windows.Forms.GroupBox();
            this.dgvCarOrders = new System.Windows.Forms.DataGridView();
            this.grpCarPartOrders = new System.Windows.Forms.GroupBox();
            this.dgvCarPartOrders = new System.Windows.Forms.DataGridView();
            this.grpCarOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarOrders)).BeginInit();
            this.grpCarPartOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarPartOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCarOrders
            // 
            this.grpCarOrders.Controls.Add(this.dgvCarOrders);
            this.grpCarOrders.Location = new System.Drawing.Point(54, 15);
            this.grpCarOrders.Margin = new System.Windows.Forms.Padding(4);
            this.grpCarOrders.Name = "grpCarOrders";
            this.grpCarOrders.Padding = new System.Windows.Forms.Padding(4);
            this.grpCarOrders.Size = new System.Drawing.Size(747, 212);
            this.grpCarOrders.TabIndex = 0;
            this.grpCarOrders.TabStop = false;
            this.grpCarOrders.Text = "My Car Orders";
            // 
            // dgvCarOrders
            // 
            this.dgvCarOrders.AllowUserToAddRows = false;
            this.dgvCarOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarOrders.Location = new System.Drawing.Point(8, 23);
            this.dgvCarOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCarOrders.Name = "dgvCarOrders";
            this.dgvCarOrders.RowHeadersWidth = 51;
            this.dgvCarOrders.Size = new System.Drawing.Size(731, 178);
            this.dgvCarOrders.TabIndex = 0;
            this.dgvCarOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCarOrders_CellContentClick);
            // 
            // grpCarPartOrders
            // 
            this.grpCarPartOrders.Controls.Add(this.dgvCarPartOrders);
            this.grpCarPartOrders.Location = new System.Drawing.Point(54, 236);
            this.grpCarPartOrders.Margin = new System.Windows.Forms.Padding(4);
            this.grpCarPartOrders.Name = "grpCarPartOrders";
            this.grpCarPartOrders.Padding = new System.Windows.Forms.Padding(4);
            this.grpCarPartOrders.Size = new System.Drawing.Size(747, 246);
            this.grpCarPartOrders.TabIndex = 1;
            this.grpCarPartOrders.TabStop = false;
            this.grpCarPartOrders.Text = "My Car Parts Orders";
            // 
            // dgvCarPartOrders
            // 
            this.dgvCarPartOrders.AllowUserToAddRows = false;
            this.dgvCarPartOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarPartOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarPartOrders.Location = new System.Drawing.Point(8, 23);
            this.dgvCarPartOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCarPartOrders.Name = "dgvCarPartOrders";
            this.dgvCarPartOrders.RowHeadersWidth = 51;
            this.dgvCarPartOrders.Size = new System.Drawing.Size(731, 215);
            this.dgvCarPartOrders.TabIndex = 0;
            this.dgvCarPartOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCarPartOrders_CellContentClick);
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpCarPartOrders);
            this.Controls.Add(this.grpCarOrders);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(850, 500);
            this.grpCarOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarOrders)).EndInit();
            this.grpCarPartOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarPartOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
