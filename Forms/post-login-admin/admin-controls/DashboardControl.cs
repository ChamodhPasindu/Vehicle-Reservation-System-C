using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ABCTradersApp.forms;

namespace ABCTradersApp.Forms.post_login_admin.admin_controls
{
    public partial class DashboardControl : UserControl
    {

        private Label lblCustomersCount;
        private Label lblCarsCount;
        private Label lblCarPartsCount;
        private Label lblOrdersCount;
        private GroupBox groupBoxCustomers;
        private GroupBox groupBoxCars;
        private GroupBox groupBoxCarParts;
        private GroupBox groupBoxOrders;
        private Label lblDashboard;
        private GroupBox groupBoxAvailableCar;
        private Label lblAvailableCars;

        private string connectionString = DatabaseConfig.ConnectionString;

        public DashboardControl()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Number of Customers
                    SqlCommand cmdCustomers = new SqlCommand("SELECT COUNT(*) FROM Customer", connection);
                    int customersCount = (int)cmdCustomers.ExecuteScalar();
                    lblCustomersCount.Text = $"Number of Customers: {customersCount}";

                    // Number of Cars
                    SqlCommand cmdCars = new SqlCommand("SELECT COUNT(*) FROM Car", connection);
                    int carsCount = (int)cmdCars.ExecuteScalar();
                    lblCarsCount.Text = $"Number of Cars: {carsCount}";

                    // Number Avaiable of Cars
                    SqlCommand cmdAvailableCars = new SqlCommand("SELECT COUNT(*) FROM Car c LEFT JOIN CustomerOrder co ON c.CarID = co.CarID WHERE co.CarID IS NULL OR co.Status != 'Ordered'", connection);
                    int avialleCarsCount = (int)cmdAvailableCars.ExecuteScalar();
                    lblAvailableCars.Text = $"Number of Available Cars: {avialleCarsCount}";

                    // Number of Car Parts
                    SqlCommand cmdCarParts = new SqlCommand("SELECT COUNT(*) FROM CarPart", connection);
                    int carPartsCount = (int)cmdCarParts.ExecuteScalar();
                    lblCarPartsCount.Text = $"Number of Car Parts: {carPartsCount}";

                    // Number of Orders
                    SqlCommand cmdOrders = new SqlCommand("SELECT COUNT(*) FROM CustomerOrder", connection);
                    int ordersCount = (int)cmdOrders.ExecuteScalar();
                    lblOrdersCount.Text = $"Number of Orders: {ordersCount}";
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
    }
}

