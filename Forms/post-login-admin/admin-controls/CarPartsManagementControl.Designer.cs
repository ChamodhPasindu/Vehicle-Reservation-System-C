namespace ABCTradersApp.Forms.post_login_admin.admin_controls
{
    partial class CarPartsManagementControl
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
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtQuatity = new System.Windows.Forms.TextBox();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblPartNumber = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewCarParts = new System.Windows.Forms.DataGridView();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.groupBoxCarPartDetails = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarParts)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            this.groupBoxCarPartDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPartName
            // 
            this.txtPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartName.Location = new System.Drawing.Point(141, 28);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(200, 22);
            this.txtPartName.TabIndex = 0;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNumber.Location = new System.Drawing.Point(141, 58);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(200, 22);
            this.txtPartNumber.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(141, 88);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(11, 31);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(392, 100);
            this.txtDescription.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(23, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(342, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // txtQuatity
            // 
            this.txtQuatity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuatity.Location = new System.Drawing.Point(141, 121);
            this.txtQuatity.Name = "txtQuatity";
            this.txtQuatity.Size = new System.Drawing.Size(200, 22);
            this.txtQuatity.TabIndex = 11;
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartName.Location = new System.Drawing.Point(21, 31);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(71, 16);
            this.lblPartName.TabIndex = 4;
            this.lblPartName.Text = "Part Name";
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartNumber.Location = new System.Drawing.Point(21, 61);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(82, 16);
            this.lblPartNumber.TabIndex = 5;
            this.lblPartNumber.Text = "Part Number";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(21, 91);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(777, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveOrEdit_Click);
            // 
            // dataGridViewCarParts
            // 
            this.dataGridViewCarParts.AllowUserToAddRows = false;
            this.dataGridViewCarParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCarParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarParts.Location = new System.Drawing.Point(23, 244);
            this.dataGridViewCarParts.Name = "dataGridViewCarParts";
            this.dataGridViewCarParts.RowHeadersWidth = 51;
            this.dataGridViewCarParts.RowTemplate.Height = 24;
            this.dataGridViewCarParts.Size = new System.Drawing.Size(854, 255);
            this.dataGridViewCarParts.TabIndex = 9;
            this.dataGridViewCarParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCars_CellClick);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(20, 121);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.txtSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(23, 174);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(386, 62);
            this.groupBoxSearch.TabIndex = 19;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.txtDescription);
            this.groupBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDescription.Location = new System.Drawing.Point(432, 11);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(445, 156);
            this.groupBoxDescription.TabIndex = 18;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Description";
            // 
            // groupBoxCarPartDetails
            // 
            this.groupBoxCarPartDetails.Controls.Add(this.lblPartName);
            this.groupBoxCarPartDetails.Controls.Add(this.txtPartName);
            this.groupBoxCarPartDetails.Controls.Add(this.txtPartNumber);
            this.groupBoxCarPartDetails.Controls.Add(this.txtQuatity);
            this.groupBoxCarPartDetails.Controls.Add(this.txtPrice);
            this.groupBoxCarPartDetails.Controls.Add(this.lblQuantity);
            this.groupBoxCarPartDetails.Controls.Add(this.lblPartNumber);
            this.groupBoxCarPartDetails.Controls.Add(this.lblPrice);
            this.groupBoxCarPartDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCarPartDetails.Location = new System.Drawing.Point(23, 11);
            this.groupBoxCarPartDetails.Name = "groupBoxCarPartDetails";
            this.groupBoxCarPartDetails.Size = new System.Drawing.Size(386, 156);
            this.groupBoxCarPartDetails.TabIndex = 17;
            this.groupBoxCarPartDetails.TabStop = false;
            this.groupBoxCarPartDetails.Text = "Car Part Details";
            // 
            // CarPartsManagementControl
            // 
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.groupBoxCarPartDetails);
            this.Controls.Add(this.dataGridViewCarParts);
            this.Controls.Add(this.btnSave);
            this.Name = "CarPartsManagementControl";
            this.Size = new System.Drawing.Size(900, 525);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarParts)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.groupBoxCarPartDetails.ResumeLayout(false);
            this.groupBoxCarPartDetails.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        
    }
}
