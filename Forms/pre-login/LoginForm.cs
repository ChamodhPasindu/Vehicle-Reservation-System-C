﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ABCTradersApp.forms;

namespace ABCTradersApp
{
    public partial class LoginForm : Form
    {
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private RadioButton radioCustomer;
        private RadioButton radioAdmin;
        private Button btnRegister;
        private Label lblLogin;
        private PictureBox LoginImage;

        private string connectionString = DatabaseConfig.ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (radioAdmin.Checked)
            {
                if (ValidateAdminLogin(username, password))
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Open admin form
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    //close login window
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if (radioCustomer.Checked)
            {
                int customerID = ValidateCustomerLogin(username, password);
                if (customerID != -1)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Open customer form with customerID
                    CustomerForm customerForm = new CustomerForm(customerID);
                    customerForm.Show();
                    // Close login window
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

           
        }

        private int ValidateCustomerLogin(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT CustomerID FROM Customer WHERE Username=@Username AND Password=@Password";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    connection.Close();

                    if (result != null && int.TryParse(result.ToString(), out int customerID))
                    {
                        return customerID;
                    }
                    return -1; // Invalid ID
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL exceptions 
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private bool ValidateAdminLogin(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(1) FROM Admin WHERE Username=@Username AND Password=@Password";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    connection.Close();

                    return count == 1;
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL exceptions 
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            //open register form
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
