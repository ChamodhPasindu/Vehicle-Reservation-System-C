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
    public partial class OrderCarDetail : Form
    {
        private int orderID;
        string connectionString = "Data Source=CHAMODH792\\SQLEXPRESS;Initial Catalog=ABCTradersDB;Integrated Security=True;Encrypt=False";

        private Label lblOrderIDLabel;
        private Label lblOrderID;
        private Label lblOrderDateLabel;
        private Label lblOrderDate;
        private Label lblTotalAmountLabel;
        private Label lblTotalAmount;
        private GroupBox groupBoxOrderInfo;
        private Label lblCustomerIDLabel;
        private Label lblCustomerID;
        private Label lblFirstNameLabel;
        private Label lblFirstName;
        private Label lblLastNameLabel;
        private Label lblLastName;
        private Label lblEmailLabel;
        private Label lblEmail;
        private Label lblPhoneLabel;
        private Label lblPhone;
        private GroupBox groupBoxCustomerInfo;
        private Label lblCarIDLabel;
        private Label lblCarID;
        private Label lblModelLabel;
        private Label lblModel;
        private Label lblManufacturerLabel;
        private Label lblManufacturer;
        private Label lblYearLabel;
        private Label lblYear;
        private GroupBox groupBoxCarInfo;
        private Button btnClose;
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
            string query = @"SELECT o.OrderID, o.OrderDate, o.TotalAmount, 
                            c.CustomerID, c.FirstName, c.LastName, c.Email, c.Phone, 
                            car.CarID, car.Model, car.Manufacturer, car.Year
                     FROM CustomerOrder o
                     JOIN Customer c ON o.CustomerID = c.CustomerID
                     JOIN Car car ON o.CarID = car.CarID
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

                            lblCarID.Text = reader["CarID"].ToString();
                            lblModel.Text = reader["Model"].ToString();
                            lblManufacturer.Text = reader["Manufacturer"].ToString();
                            lblYear.Text = reader["Year"].ToString();
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
    }
}
