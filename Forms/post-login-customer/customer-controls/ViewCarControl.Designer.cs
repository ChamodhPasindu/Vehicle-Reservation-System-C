namespace ABCTradersApp.Forms.post_login_customer.customer_controls
{
    partial class ViewCarControl
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.carGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.carGridView)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(20, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(343, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // carGridView
            // 
            this.carGridView.AllowUserToAddRows = false;
            this.carGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carGridView.Location = new System.Drawing.Point(20, 90);
            this.carGridView.Name = "carGridView";
            this.carGridView.RowHeadersWidth = 51;
            this.carGridView.RowTemplate.Height = 24;
            this.carGridView.Size = new System.Drawing.Size(849, 385);
            this.carGridView.TabIndex = 1;
            this.carGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarGridView_CellClick);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.txtSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(20, 18);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(386, 62);
            this.groupBoxSearch.TabIndex = 21;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // ViewCarControl
            // 
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.carGridView);
            this.Name = "ViewCarControl";
            this.Size = new System.Drawing.Size(900, 525);
            ((System.ComponentModel.ISupportInitialize)(this.carGridView)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

    }
}
