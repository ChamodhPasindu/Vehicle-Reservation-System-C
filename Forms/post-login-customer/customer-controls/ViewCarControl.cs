using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABCTradersApp.Forms.post_login_customer.customer_controls
{
    public partial class ViewCarControl : UserControl
    {
        private int customerID;

        private TextBox txtSearch;
        private DataGridView carGridView;
        private GroupBox groupBoxSearch;

        private string connectionString = "Data Source=CHAMODH792\\SQLEXPRESS;Initial Catalog=ABCTradersDB;Integrated Security=True;Encrypt=False";

        public ViewCarControl(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            LoadAvailableCar();
        }

        private void LoadAvailableCar()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT c.CarID, c.Model, c.Manufacturer, c.Year, c.Price  FROM Car c LEFT JOIN CustomerOrder co ON c.CarID = co.CarID WHERE co.CarID IS NULL OR co.Status != 'Ordered'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    carGridView.DataSource = dataTable;

                    // Set the columns to fill the full width of the DataGridView
                    carGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Add "Edit" button column
                    if (!carGridView.Columns.Contains("View"))
                    {
                        DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "View",
                            Text = "View",
                            UseColumnTextForButtonValue = true
                        };
                        carGridView.Columns.Add(viewButtonColumn);
                    }
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

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //filter cars by search text
            FilterCarsData(txtSearch.Text);
        }

        private void FilterCarsData(string filterText)
        {
            //match search text with every colounm in car table 
            string rowFilter = string.Format(
        "Model LIKE '%{0}%' OR Manufacturer LIKE '%{0}%' OR CONVERT(Year, 'System.String') LIKE '%{0}%'",
         filterText);
            (carGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void CarGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == carGridView.Columns["View"].Index && e.RowIndex >= 0)
            {
                int carID = Convert.ToInt32(carGridView.Rows[e.RowIndex].Cells["CarID"].Value);
                ViewCarDetail carDetailForm = new ViewCarDetail(carID, customerID);

                carDetailForm.FormClosed += CarDetailForm_FormClosed;
                carDetailForm.Show();
            }
        }

        private void CarDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadAvailableCar();
        }
    }

}
