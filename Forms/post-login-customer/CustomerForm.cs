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

namespace ABCTradersApp
{
    public partial class CustomerForm : Form
    {
        private Panel panelSideMenu;
        private Button btnViewCars;
        private Button btnViewCarParts;
        private Button btnOrders;
        private Button btnViewOrderStatus;
        private Button btnLogout;
        private Button btnDashboard;
        private Panel panelMainContent;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void LoadDashboard()
        {
            // Default message or content
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard(); // Load the default dashboard view
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            //close admin window
            this.Close();
        }

        private void BtnViewCars_Click(object sender, EventArgs e)
        {
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
        }
        private void BtnViewCarParts_Click(object sender, EventArgs e)
        {
        }
        private void BtnViewOrderStatus_Click(object sender, EventArgs e)
        {
        }

    }
}
