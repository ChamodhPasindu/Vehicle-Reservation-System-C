using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

           if (ValidateLogin(username, password, role))
            {
                MessageBox.Show("Login successful!");

                if (role == "Admin")
                {
                    //Open admin form
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else if (role == "Customer")
                {
                    //Open customer form
                   CustomerForm customerForm = new CustomerForm();
                   customerForm.Show();
                }

                //close login window
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }
        }

        private bool ValidateLogin(string username, string password, string role)
        {

            return true;
       
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
