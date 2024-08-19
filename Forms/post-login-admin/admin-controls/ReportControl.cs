using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using ABCTradersApp.forms;

namespace ABCTradersApp.Forms.post_login_admin.admin_controls
{
    public partial class ReportControl : UserControl
    {
        private Button btnGenerateReport;
        private Button btnExportToPDF;
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private Label lblFromDate;
        private Label lblToDate;
        private DataGridView dgvReportData;
        private GroupBox groupBoxFilter;
        private Button btnCustomerReport;
        private Button btnCarPartReport;
        private Button btnCarReport;

        private string connectionString = DatabaseConfig.ConnectionString;

        public ReportControl()
        {
            InitializeComponent();
            GenerateReport();
        }

        private void GenerateReport()
        {
            try
            {
                string query = "SELECT OrderID, CustomerID, OrderDate, TotalAmount FROM CustomerOrder WHERE OrderDate BETWEEN @FromDate AND @ToDate";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FromDate", dtpFromDate.Value);
                    cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable reportData = new DataTable();
                    adapter.Fill(reportData);
                    dgvReportData.DataSource = reportData;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void BtnExportToPDF_Click(object sender, EventArgs e)
        {
            // Validate that dgvReportData has data
            if (dgvReportData.Rows.Count == 0)
            {
                MessageBox.Show("No data available to generate the report.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Save Report as PDF",
                FileName = "OrderReport"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (FileStream stream = new FileStream(filePath, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Paragraph("Order Report"));
                        pdfDoc.Add(new Paragraph("From: " + dtpFromDate.Value.ToString("dd/MM/yyyy") + " To: " + dtpToDate.Value.ToString("dd/MM/yyyy")));
                        pdfDoc.Add(new Paragraph(" "));

                        PdfPTable pdfTable = new PdfPTable(dgvReportData.ColumnCount);
                        foreach (DataGridViewColumn column in dgvReportData.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dgvReportData.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value?.ToString() ?? string.Empty);
                            }
                        }

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCustomerReport_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Customer";
            GeneratePDFReport(query, "CustomerReport.pdf");
        }

        private void BtnCarPartReport_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM CarPart";
            GeneratePDFReport(query, "CarPartReport.pdf");
        }

        private void BtnCarReport_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Car";
            GeneratePDFReport(query, "CarReport.pdf");
        }

        private void GeneratePDFReport(string query, string defaultFileName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                SaveFileDialog saveFileDialog = new SaveFileDialog
                                {
                                    Filter = "PDF files (*.pdf)|*.pdf",
                                    Title = "Save report as PDF",
                                    FileName = defaultFileName
                                };

                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    ExportDataToPDF(reader, saveFileDialog.FileName);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found for the report.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message);
            }
        }

        private void ExportDataToPDF(SqlDataReader reader, string filePath)
        {
            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    PdfPTable pdfTable = new PdfPTable(reader.FieldCount);
                    pdfTable.WidthPercentage = 100;

                    // Add headers
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i)));
                        pdfTable.AddCell(cell);
                    }

                    // Add rows
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            pdfTable.AddCell(reader[i].ToString());
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                }

                MessageBox.Show("PDF report generated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF: " + ex.Message);
            }
        }
    }
}
