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
    public partial class Login : Form
    {
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private ComboBox cmbRole;
        private Button btnRegister;

        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem.ToString();

           if (ValidateLogin(username, password, role))
            {
                MessageBox.Show("Login successful!");

                if (role == "Admin")
                {
                
                }
                else if (role == "Customer")
                {
              
               }

   
            }
            else
            {
       
            }
        }

        private bool ValidateLogin(string username, string password, string role)
        {

            return true;
        
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }
    }
}
