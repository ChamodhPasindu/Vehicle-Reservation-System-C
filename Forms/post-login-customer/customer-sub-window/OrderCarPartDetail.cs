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

namespace ABCTradersApp.Forms.post_login_customer.customer_controls
{
    public partial class OrderCarPartDetail : Form
    {
        private int orderID;

        private string connectionString = "Data Source=CHAMODH792\\SQLEXPRESS;Initial Catalog=ABCTradersDB;Integrated Security=True;Encrypt=False";
        private DataGridView dgvCarParts;
        private Button btnClose;

        public OrderCarPartDetail(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
            LoadOrderDetails(orderID);
            LoadOrderItems(orderID);
        }

        private void LoadOrderDetails(int orderID)
        {
            string query = @"SELECT o.OrderID, o.OrderDate, o.TotalAmount 
                     FROM CustomerOrder o
                     WHERE o.OrderID = @OrderID";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Assign values to labels
                        lblOrderId.Text = reader["OrderID"].ToString();
                        lblOrderDate.Text = reader["OrderDate"].ToString();
                        lblTotalAmount.Text = "LKR " + reader["TotalAmount"].ToString();
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

        private void LoadOrderItems(int orderID)
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
