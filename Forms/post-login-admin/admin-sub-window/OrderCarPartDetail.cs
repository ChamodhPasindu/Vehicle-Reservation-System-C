using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ABCTradersApp.forms;

namespace ABCTradersApp.Forms.post_login_admin.admin_controls
{
    public partial class OrderCarPartDetail : Form
    {
        private int orderID;
        private string connectionString = DatabaseConfig.ConnectionString;

        private GroupBox groupBoxOrderInfo;
        private Label lblTotalAmount;
        private Label lblTotalAmountLabel;
        private Label lblOrderDate;
        private Label lblOrderDateLabel;
        private Label lblOrderID;
        private Label lblOrderIDLabel;
        private Button btnClose;
        public OrderCarPartDetail(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
            LoadOrderDetails();
            LoadOrderItems();
        }

        private void LoadOrderDetails()
        {
            string query = @"SELECT o.OrderID, o.OrderDate, o.TotalAmount, 
                            c.CustomerID, c.FirstName, c.LastName, c.Email, c.Phone
                     FROM CustomerOrder o
                     JOIN Customer c ON o.CustomerID = c.CustomerID
                     WHERE o.OrderID = @OrderID";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@OrderID", orderID);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assign values to labels
                            lblOrderID.Text = reader["OrderID"].ToString();
                            lblOrderDate.Text = Convert.ToDateTime(reader["OrderDate"]).ToString("MM/dd/yyyy");
                            lblTotalAmount.Text = "LKR " + reader["TotalAmount"].ToString();

                            lblCustomerID.Text = reader["CustomerID"].ToString();
                            lblFirstName.Text = reader["FirstName"].ToString();
                            lblLastName.Text = reader["LastName"].ToString();
                            lblEmail.Text = reader["Email"].ToString();
                            lblPhone.Text = reader["Phone"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Order not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void LoadOrderItems()
        {
            string query = @"SELECT cp.PartName, oi.Quantity, oi.UnitPrice 
                     FROM OrderItem oi
                     JOIN CarPart cp ON oi.CarPartID = cp.CarPartID
                     WHERE oi.OrderID = @OrderID";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable orderItemsTable = new DataTable();
                    adapter.Fill(orderItemsTable);
                    dgvCarParts.DataSource = orderItemsTable;
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
