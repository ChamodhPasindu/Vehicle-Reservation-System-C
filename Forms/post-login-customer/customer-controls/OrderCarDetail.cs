using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABCTradersApp.Forms.post_login_customer.customer_controls
{
    public partial class OrderCarDetail : Form
    {
        private GroupBox grpOrderDetails;
        private Label lblOrderDate;
        private Label lblTotalAmount;
        private Label lblCarID;
        private Label lblModel;
        private Label lblManufacturer;
        private Label lblYear;
        private Label lblPrice;
        private Label lblDescription;
        private Button btnClose;

        private int orderID;

        private string connectionString = "Data Source=CHAMODH792\\SQLEXPRESS;Initial Catalog=ABCTradersDB;Integrated Security=True;Encrypt=False";

        public OrderCarDetail(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
            LoadOrderDetails();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadOrderDetails()
        {
            string query = @"SELECT o.OrderID, o.OrderDate, o.TotalAmount, c.CarID, c.Model, c.Manufacturer, c.Year, c.Price, c.Description 
                     FROM CustomerOrder o
                     JOIN Car c ON o.CarID = c.CarID
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
                        lblOrderID.Text = reader["OrderID"].ToString();
                        lblOrderDate.Text = reader["OrderDate"].ToString();
                        lblTotalAmount.Text = "LKR " + reader["TotalAmount"].ToString();
                        lblCarID.Text = reader["CarID"].ToString();
                        lblModel.Text = reader["Model"].ToString();
                        lblManufacturer.Text = reader["Manufacturer"].ToString();
                        lblYear.Text = reader["Year"].ToString();
                        lblPrice.Text = "LKR " + reader["Price"].ToString();
                        lblDescription.Text = reader["Description"].ToString();
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
