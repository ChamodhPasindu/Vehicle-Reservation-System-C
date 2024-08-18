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
    public partial class ViewCarPartControl : UserControl
    {

        private ComboBox cmbPartName;
        private Label lblPartNumber;
        private Label lblPrice;
        private Label lblDescription;
        private Label lblAvailableQuantity;
        private TextBox txtOrderQuantity;
        private Button btnAddToCart;
        private Label lblStaticPartNo;
        private Label lblStaticPrice;
        private Label lblStaticDescription;
        private Label lblStaticQty;
        private GroupBox groupBoxOrderDetails;
        private GroupBox groupBoxCarParts;
        private Label lblTotalLabel;
        private Label lblTotalValue;
        private DataGridView cartGridView;
        private DataGridViewTextBoxColumn PartName;
        private DataGridViewTextBoxColumn PartNumber;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalColumn;
        private Button btnOrder;

        private int customerID;
        private string connectionString = "Data Source=CHAMODH792\\SQLEXPRESS;Initial Catalog=ABCTradersDB;Integrated Security=True;Encrypt=False";


        public ViewCarPartControl(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.cmbPartName.Items.Add("Select Car Part");
            this.cmbPartName.SelectedIndex = 0;
            LoadPartNames();
            lblTotalValue.Text = "0";
           
        }

        private void LoadPartNames()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT PartName FROM CarPart WHERE Quantity > 0";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbPartName.Items.Add(reader["PartName"].ToString());
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

        private void CmbPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPartName.SelectedIndex > 0) // Check if selected item is not the default
            {
                string selectedPartName = cmbPartName.SelectedItem.ToString();

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT PartNumber, Price, Description, Quantity FROM CarPart WHERE PartName = @PartName";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@PartName", selectedPartName);

                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            lblPartNumber.Text = reader["PartNumber"].ToString();
                            lblPrice.Text = reader["Price"].ToString();
                            lblDescription.Text = reader["Description"].ToString();
                            lblAvailableQuantity.Text = reader["Quantity"].ToString();
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
            else
            {
                ClearTextFields();
            }
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblAvailableQuantity.Text) || string.IsNullOrWhiteSpace(txtOrderQuantity.Text))
            {
                // If either is empty or whitespace, return or perform another action
                MessageBox.Show("Please make sure all fields are filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int availableQuantity = Convert.ToInt32(lblAvailableQuantity.Text);
            int orderQuantity = Convert.ToInt32(txtOrderQuantity.Text);

            if (orderQuantity > availableQuantity)
            {
                MessageBox.Show("Quantity exceeds available stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal price = Convert.ToDecimal(lblPrice.Text);
            decimal total = orderQuantity * price;

            // Add to cart
            cartGridView.Rows.Add(cmbPartName.SelectedItem.ToString(), lblPartNumber.Text, orderQuantity, price, total);

            // Update total value
            decimal currentTotal = Convert.ToDecimal(lblTotalValue.Text);
            lblTotalValue.Text = (currentTotal + total).ToString();

            // Clear input fields
            txtOrderQuantity.Clear();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            // Validate that the cart is not empty
            if (cartGridView.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items to your cart before placing an order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that total amount is greater than 0
            if (string.IsNullOrWhiteSpace(lblTotalValue.Text) || Convert.ToDecimal(lblTotalValue.Text) <= 0)
            {
                MessageBox.Show("The total amount must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Insert order into CustomerOrder table
                    string insertOrderQuery = "INSERT INTO CustomerOrder (CustomerID, TotalAmount, Status) OUTPUT INSERTED.OrderID VALUES (@CustomerID, @TotalAmount, 'Ordered')";
                    SqlCommand insertOrderCmd = new SqlCommand(insertOrderQuery, connection, transaction);
                    insertOrderCmd.Parameters.AddWithValue("@CustomerID", customerID);
                    insertOrderCmd.Parameters.AddWithValue("@TotalAmount", Convert.ToDecimal(lblTotalValue.Text));

                    int orderID = (int)insertOrderCmd.ExecuteScalar();

                    // Insert items into OrderItem table and update CarPart quantity
                    foreach (DataGridViewRow row in cartGridView.Rows)
                    {
                        string partName = row.Cells["PartName"].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                        string insertItemQuery = "INSERT INTO OrderItem (OrderID, CarPartID, Quantity, UnitPrice) VALUES (@OrderID, (SELECT CarPartID FROM CarPart WHERE PartName = @PartName), @Quantity, @UnitPrice)";
                        SqlCommand insertItemCmd = new SqlCommand(insertItemQuery, connection, transaction);
                        insertItemCmd.Parameters.AddWithValue("@OrderID", orderID);
                        insertItemCmd.Parameters.AddWithValue("@PartName", partName);
                        insertItemCmd.Parameters.AddWithValue("@Quantity", quantity);
                        insertItemCmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal(row.Cells["Price"].Value));
                        insertItemCmd.ExecuteNonQuery();

                        string updateQuantityQuery = "UPDATE CarPart SET Quantity = Quantity - @Quantity WHERE PartName = @PartName";
                        SqlCommand updateQuantityCmd = new SqlCommand(updateQuantityQuery, connection, transaction);
                        updateQuantityCmd.Parameters.AddWithValue("@Quantity", quantity);
                        updateQuantityCmd.Parameters.AddWithValue("@PartName", partName);
                        updateQuantityCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextFields();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ClearTextFields()
        {
            this.cmbPartName.SelectedIndex = 0;

            lblPrice.Text = string.Empty;
            lblPartNumber.Text = string.Empty;
            lblDescription.Text = string.Empty;
            lblAvailableQuantity.Text = string.Empty;
            txtOrderQuantity.Clear();
            cartGridView.Rows.Clear();

        }

        
    }
}
