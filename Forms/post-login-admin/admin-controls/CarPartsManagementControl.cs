using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTradersApp.Forms.post_login_admin.admin_controls
{
    public partial class CarPartsManagementControl : UserControl
    {
        private TextBox txtPartName;
        private TextBox txtPartNumber;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private Label lblPartName;
        private Label lblPartNumber;
        private Label lblPrice;
        private Label lblDescription;
        private Button btnSave;
        private DataGridView dataGridViewCarParts;

        private string connectionString = "Data Source=CHAMODH792\\SQLEXPRESS;Initial Catalog=ABCTradersDB;Integrated Security=True;Encrypt=False";

        public CarPartsManagementControl()
        {
            InitializeComponent();
            LoadCarParts();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string partName = txtPartName.Text;
            string partNumber = txtPartNumber.Text;
            string price = txtPrice.Text;
            string description = txtDescription.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO CarPart (PartName, PartNumber, Price, Description) " +
                                   "VALUES (@PartName, @PartNumber, @Price, @Description)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PartName", partName);
                        command.Parameters.AddWithValue("@PartNumber", partNumber);
                        command.Parameters.AddWithValue("@Price", decimal.Parse(price));
                        command.Parameters.AddWithValue("@Description", description);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL exceptions 
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Car part saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCarParts(); // Refresh the DataGridView
        }

        private void LoadCarParts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM CarPart";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewCarParts.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL exceptions 
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
