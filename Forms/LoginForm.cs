﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABCTradersApp
{
    public partial class LoginForm : Form
    {
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private ComboBox cmbRole;
        private Button btnRegister;

        public LoginForm()
        {
            InitializeComponent();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem.ToString();

            if (role == "Admin")
            {
                if (ValidateAdminLogin(username, password))
                {
                    MessageBox.Show("Login successful!");
                    //Open admin form
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    //close login window
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
                
            }
            else if (role == "Customer")
            {
                if (ValidateCustomerLogin(username, password))
                {
                    MessageBox.Show("Login successful!");
                    //Open customer form
                    CustomerForm customerForm = new CustomerForm();
                    customerForm.Show();
                    //close login window
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
              
            }

           
        }

        private bool ValidateCustomerLogin(string username, string password)
        {
            // Example connection string
            string connectionString = "Data Source=CHAMODH792\\SQLEXPRESS;Initial Catalog=ABCTradersDB;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(1) FROM Customer WHERE Username=@Username AND Password=@Password";
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
                // Handle SQL exceptions (e.g., connection issues, command issues)
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

        private bool ValidateAdminLogin(string username, string password)
        {

            // Example connection string
            string connectionString = "Data Source=CHAMODH792\\SQLEXPRESS;Initial Catalog=ABCTradersDB;Integrated Security=True;Encrypt=False";

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
                // Handle SQL exceptions (e.g., connection issues, command issues)
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
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
