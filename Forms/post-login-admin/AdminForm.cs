using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABCTradersApp.Forms.post_login_admin.admin_controls;

namespace ABCTradersApp
{
    public partial class AdminForm : Form
    {
        private Panel panelSideMenu;
        private Button btnCarParts;
        private Button btnCustomers;
        private Button btnOrders;
        private Button btnReports;
        private Button btnLogout;
        private Button btnDashboard;
        private Panel panelMainContent;
        public AdminForm()
        {
            InitializeComponent();
            LoadDashboard();
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
            LoginForm loginForm= new LoginForm();
            loginForm.Show();
            //close admin window
            this.Close();
        }

        private void BtnCars_Click(object sender, EventArgs e)
        {
            // Load car management controls into panelMainContent
            panelMainContent.Controls.Clear();
            CarManagementControl carControl = new CarManagementControl();
            carControl.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(carControl);
        }

        private void BtnCarParts_Click(object sender, EventArgs e)
        {
            // Load car parts management controls into panelMainContent
            panelMainContent.Controls.Clear();
            CarPartsManagementControl carPartControl = new CarPartsManagementControl();
            carPartControl.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(carPartControl);
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            // Load customer management controls into panelMainContent
            panelMainContent.Controls.Clear();
            CustomerManagementControl customerControl = new CustomerManagementControl();
            customerControl.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(customerControl);
        }
        private void BtnOrders_Click(object sender, EventArgs e)
        {
            // Load order management controls into panelMainContent
            panelMainContent.Controls.Clear();
            OrdersManagementControl orderControl = new OrdersManagementControl();
            orderControl.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(orderControl);
        }
        private void BtnReports_Click(object sender, EventArgs e)
        {
            // Load reports controls into panelMainContent
            panelMainContent.Controls.Clear();
            ReportsControl reportsControl = new ReportsControl();
            reportsControl.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(reportsControl);
        }

    }
}
