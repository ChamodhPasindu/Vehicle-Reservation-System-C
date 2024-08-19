using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ABCTradersApp.forms;

namespace ABCTradersApp.Forms.post_login_customer.customer_controls
{
    public partial class DashboardControl : UserControl
    {

        private Label lblTotalCarParts;
        private Label lblTotalCars;
        private Label lblTotalOrders;
        private Label lblTotalCarPartsValue;
        private Label lblTotalCarsValue;
        private Label lblTotalOrdersValue;
        private Label lblDashboard;
        private GroupBox groupBoxCarParts;
        private GroupBox groupBoxCars;
        private GroupBox groupBoxOrders;

        private int customerID;
        private string connectionString = DatabaseConfig.ConnectionString;


        public DashboardControl(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Total Car Parts
                    string queryCarParts = "SELECT COUNT(*) FROM CarPart";
                    SqlCommand commandCarParts = new SqlCommand(queryCarParts, connection);
                    int totalCarParts = (int)commandCarParts.ExecuteScalar();
                    lblTotalCarPartsValue.Text = totalCarParts.ToString();

                    // Total Cars
                    string queryCars = "SELECT COUNT(*) FROM Car";
                    SqlCommand commandCars = new SqlCommand(queryCars, connection);
                    int totalCars = (int)commandCars.ExecuteScalar();
                    lblTotalCarsValue.Text = totalCars.ToString();

                    // Total Orders
                    string queryOrders = "SELECT COUNT(*) FROM CustomerOrder WHERE CustomerID = @CustomerID";
                    SqlCommand commandOrders = new SqlCommand(queryOrders, connection);
                    commandOrders.Parameters.AddWithValue("@CustomerID", customerID); // Replace with actual customer ID
                    int totalOrders = (int)commandOrders.ExecuteScalar();
                    lblTotalOrdersValue.Text = totalOrders.ToString();
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
    }
}
