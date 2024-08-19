using System.Windows.Forms;

namespace ABCTradersApp.Forms.post_login_admin.admin_controls
{
    partial class ReportControl
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
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvReportData = new System.Windows.Forms.DataGridView();
            this.btnExportToPDF = new System.Windows.Forms.Button();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.btnCustomerReport = new System.Windows.Forms.Button();
            this.btnCarPartReport = new System.Windows.Forms.Button();
            this.btnCarReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).BeginInit();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(16, 24);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(73, 16);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "From Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Location = new System.Drawing.Point(88, 21);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(242, 22);
            this.dtpFromDate.TabIndex = 1;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(16, 62);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(59, 16);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "To Date:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(88, 59);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(242, 22);
            this.dtpToDate.TabIndex = 3;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(367, 51);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(100, 30);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // dgvReportData
            // 
            this.dgvReportData.AllowUserToAddRows = false;
            this.dgvReportData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportData.Location = new System.Drawing.Point(33, 134);
            this.dgvReportData.Name = "dgvReportData";
            this.dgvReportData.RowHeadersWidth = 51;
            this.dgvReportData.Size = new System.Drawing.Size(831, 340);
            this.dgvReportData.TabIndex = 5;
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToPDF.Location = new System.Drawing.Point(666, 51);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(150, 30);
            this.btnExportToPDF.TabIndex = 6;
            this.btnExportToPDF.Text = "Export to PDF";
            this.btnExportToPDF.Click += new System.EventHandler(this.BtnExportToPDF_Click);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.dtpFromDate);
            this.groupBoxFilter.Controls.Add(this.btnGenerateReport);
            this.groupBoxFilter.Controls.Add(this.btnExportToPDF);
            this.groupBoxFilter.Controls.Add(this.lblToDate);
            this.groupBoxFilter.Controls.Add(this.lblFromDate);
            this.groupBoxFilter.Controls.Add(this.dtpToDate);
            this.groupBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilter.Location = new System.Drawing.Point(33, 27);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(831, 97);
            this.groupBoxFilter.TabIndex = 7;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // btnCustomerReport
            // 
            this.btnCustomerReport.Location = new System.Drawing.Point(33, 483);
            this.btnCustomerReport.Name = "btnCustomerReport";
            this.btnCustomerReport.Size = new System.Drawing.Size(125, 33);
            this.btnCustomerReport.TabIndex = 8;
            this.btnCustomerReport.Text = "Customer Report";
            this.btnCustomerReport.UseVisualStyleBackColor = true;
            this.btnCustomerReport.Click += new System.EventHandler(this.BtnCustomerReport_Click);
            // 
            // btnCarPartReport
            // 
            this.btnCarPartReport.Location = new System.Drawing.Point(375, 483);
            this.btnCarPartReport.Name = "btnCarPartReport";
            this.btnCarPartReport.Size = new System.Drawing.Size(125, 33);
            this.btnCarPartReport.TabIndex = 9;
            this.btnCarPartReport.Text = "Car Part Report";
            this.btnCarPartReport.UseVisualStyleBackColor = true;
            this.btnCarPartReport.Click += new System.EventHandler(this.BtnCarPartReport_Click);
            // 
            // btnCarReport
            // 
            this.btnCarReport.Location = new System.Drawing.Point(739, 483);
            this.btnCarReport.Name = "btnCarReport";
            this.btnCarReport.Size = new System.Drawing.Size(125, 33);
            this.btnCarReport.TabIndex = 10;
            this.btnCarReport.Text = "Car Report";
            this.btnCarReport.UseVisualStyleBackColor = true;
            this.btnCarReport.Click += new System.EventHandler(this.BtnCarReport_Click);
            // 
            // ReportControl
            // 
            this.Controls.Add(this.btnCarReport);
            this.Controls.Add(this.btnCarPartReport);
            this.Controls.Add(this.btnCustomerReport);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.dgvReportData);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(900, 525);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).EndInit();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        
    }
}
