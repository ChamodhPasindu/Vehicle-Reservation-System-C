using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ABCTradersApp.forms;

namespace ABCTradersApp.Forms.post_login_admin.admin_controls
{
    public partial class CustomerManagementControl : UserControl
    {
        private TextBox txtSearch;
        private DataGridView dataGridViewCustomers;
        private GroupBox groupBoxSearch;

        private string connectionString = DatabaseConfig.ConnectionString;
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

                    //add 'View' button
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
            //handle exceptions
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
            //check user enter text with the data grid view columns
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
            //open new customer detail window
            CustomerDetailForm detailsForm = new CustomerDetailForm(customerID);
            detailsForm.ShowDialog();
        }
    }
}
