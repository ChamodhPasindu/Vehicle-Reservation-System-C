using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ABCTradersApp.forms;

namespace ABCTradersApp.Forms.post_login_admin.admin_controls
{
    public partial class CustomerDetailForm : Form
    {
        private Label lblCustomerID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblNIC;
        private Label lblAddress;
        private Label lblTotalOrders;
        private Label lblCustomerIDValue;
        private Label lblFirstNameValue;
        private Label lblLastNameValue;
        private Label lblEmailValue;
        private Label lblPhoneValue;
        private Label lblNICValue;
        private Label lblAddressValue;
        private Label lblTotalOrdersValue;

        private GroupBox groupBoxPersonalInfo;
        private GroupBox groupBoxContactDetails;
        private GroupBox groupBoxOrderDetails;



        private int customerID;
        private string connectionString = DatabaseConfig.ConnectionString;


        public CustomerDetailForm(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            LoadCustomerDetails();
        }


        private void LoadCustomerDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Customer WHERE CustomerID = @CustomerID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate the customer details on the form
                        lblCustomerIDValue.Text = reader["CustomerID"].ToString();
                        lblFirstNameValue.Text = reader["FirstName"].ToString();
                        lblLastNameValue.Text = reader["LastName"].ToString();
                        lblEmailValue.Text = reader["Email"].ToString();
                        lblPhoneValue.Text = reader["Phone"].ToString();
                        lblNICValue.Text = reader["NIC"].ToString();
                        lblAddressValue.Text = reader["Address"].ToString();

                        // Load total order count
                        LoadOrderCount();
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

        private void LoadOrderCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM CustomerOrder WHERE CustomerID = @CustomerID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    connection.Open();
                    int orderCount = (int)command.ExecuteScalar();
                    lblTotalOrdersValue.Text = orderCount.ToString();
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
