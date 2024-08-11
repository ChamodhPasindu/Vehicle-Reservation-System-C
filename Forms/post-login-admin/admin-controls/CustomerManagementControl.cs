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
    public partial class CustomerManagementControl : UserControl
    {
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dataGridViewCustomers;

        private string connectionString = "Data Source=CHAMODH792\\SQLEXPRESS;Initial Catalog=ABCTradersDB;Integrated Security=True;Encrypt=False";

        public CustomerManagementControl()
        {
            InitializeComponent();
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT CustomerID, FirstName, LastName, Email, Phone FROM Customer";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewCustomers.DataSource = dataTable;

                    // Set the columns to fill the full width of the DataGridView
                    dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (!dataGridViewCustomers.Columns.Contains("View"))
                    {
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "View",
                            Text = "View",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridViewCustomers.Columns.Add(editButtonColumn);
                    }
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

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewCustomers.DataSource as DataTable).DefaultView.RowFilter = string.Format(
                "FirstName LIKE '%{0}%' OR LastName LIKE '%{0}%' OR Email LIKE '%{0}%' OR Phone LIKE '%{0}%'",
                txtSearch.Text);

        }

        private void DataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCustomers.Columns["View"].Index && e.RowIndex >= 0)
            {
                int customerID = Convert.ToInt32(dataGridViewCustomers.Rows[e.RowIndex].Cells["CustomerID"].Value);
                OpenCustomerDetailsForm(customerID);
            }
        }

        private void OpenCustomerDetailsForm(int customerID)
        {
            CustomerDetailForm detailsForm = new CustomerDetailForm(customerID);
            detailsForm.ShowDialog();
        }
    }
}
