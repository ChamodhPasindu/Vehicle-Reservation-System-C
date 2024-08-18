namespace ABCTradersApp.Forms.post_login_admin.admin_controls
{
    partial class CarManagementControl
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
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBoxCarDetails = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.groupBoxCarDetails.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(17, 245);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.RowHeadersWidth = 51;
            this.dataGridViewCars.Size = new System.Drawing.Size(854, 268);
            this.dataGridViewCars.TabIndex = 0;
            this.dataGridViewCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCars_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(752, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveOrEdit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(22, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(344, 22);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // groupBoxCarDetails
            // 
            this.groupBoxCarDetails.Controls.Add(this.lblPrice);
            this.groupBoxCarDetails.Controls.Add(this.lblYear);
            this.groupBoxCarDetails.Controls.Add(this.lblManufacturer);
            this.groupBoxCarDetails.Controls.Add(this.lblModel);
            this.groupBoxCarDetails.Controls.Add(this.txtPrice);
            this.groupBoxCarDetails.Controls.Add(this.txtYear);
            this.groupBoxCarDetails.Controls.Add(this.txtManufacturer);
            this.groupBoxCarDetails.Controls.Add(this.txtModel);
            this.groupBoxCarDetails.Location = new System.Drawing.Point(17, 13);
            this.groupBoxCarDetails.Name = "groupBoxCarDetails";
            this.groupBoxCarDetails.Size = new System.Drawing.Size(386, 156);
            this.groupBoxCarDetails.TabIndex = 14;
            this.groupBoxCarDetails.TabStop = false;
            this.groupBoxCarDetails.Text = "Car Details";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 119);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Price:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(19, 88);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 16);
            this.lblYear.TabIndex = 17;
            this.lblYear.Text = "Year:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(19, 59);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(87, 16);
            this.lblManufacturer.TabIndex = 16;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(20, 32);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(48, 16);
            this.lblModel.TabIndex = 15;
            this.lblModel.Text = "Model:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(130, 116);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 14;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(130, 85);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(200, 22);
            this.txtYear.TabIndex = 13;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(130, 56);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(200, 22);
            this.txtManufacturer.TabIndex = 12;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(130, 29);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(200, 22);
            this.txtModel.TabIndex = 11;
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.txtDescription);
            this.groupBoxDescription.Location = new System.Drawing.Point(426, 13);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(445, 156);
            this.groupBoxDescription.TabIndex = 15;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(22, 22);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(401, 113);
            this.txtDescription.TabIndex = 6;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.txtSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(17, 172);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(386, 62);
            this.groupBoxSearch.TabIndex = 16;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // CarManagementControl
            // 
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.groupBoxCarDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridViewCars);
            this.Name = "CarManagementControl";
            this.Size = new System.Drawing.Size(901, 526);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.groupBoxCarDetails.ResumeLayout(false);
            this.groupBoxCarDetails.PerformLayout();
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        
    }
}
