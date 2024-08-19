using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ABCTradersApp.forms;

namespace ABCTradersApp.Forms.post_login_customer.customer_controls
{
    public partial class ViewCarDetail : Form
    {
        private int carID;
        private int customerID;
        private Button btnOrder;
        private Button btnCancel;
        private GroupBox groupBoxCarDetails;
        private Label lblDescriptionValue;
        private Label lblPriceValue;
        private Label lblYearValue;
        private Label lblManufacturerValue;
        private Label lblModelValue;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblYear;
        private Label lblManufacturer;
        private Label lblModel;

        private string connectionString = DatabaseConfig.ConnectionString;


        public ViewCarDetail(int carID, int customerID)
        {
            InitializeComponent();
            this.carID = carID;
            this.customerID = customerID;
            LoadCarDetail();
        }

        private void LoadCarDetail()
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT Model, Manufacturer, Year, Price, Description FROM Car WHERE CarID = @CarID";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@CarID", carID);

                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblModelValue.Text = reader["Model"].ToString();
                                lblManufacturerValue.Text = reader["Manufacturer"].ToString();
                                lblYearValue.Text = reader["Year"].ToString();
                                lblPriceValue.Text = reader["Price"].ToString();
                                lblDescriptionValue.Text = reader["Description"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Car not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        connection.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Insert order into the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO CustomerOrder (CustomerID, CarID, TotalAmount, Status) " +
                                   "VALUES (@CustomerID, @CarID, @TotalAmount, 'Ordered')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@CarID", carID);
                    cmd.Parameters.AddWithValue("@TotalAmount", lblPriceValue.Text); // Set car price here

                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Car ordered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //close customer register window
                        this.Close();
                    }
                    connection.Close();
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
