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
    public partial class CarManagementControl : UserControl
    {

        private DataGridView dataGridViewCars;
        private TextBox txtModel;
        private TextBox txtManufacturer;
        private TextBox txtYear;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private Button btnSave;
        private Label lblModel;
        private Label lblManufacturer;
        private Label lblYear;
        private Label lblPrice;
        private Label lblDescription;

        private string connectionString = "Data Source=CHAMODH792\\SQLEXPRESS;Initial Catalog=ABCTradersDB;Integrated Security=True;Encrypt=False";


        public CarManagementControl()
        {
            InitializeComponent();
            LoadCarData();
        }

        private void LoadCarData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Car";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewCars.DataSource = dataTable;

                    // Add "Edit" button column
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                    editButtonColumn.Name = "Edit";
                    editButtonColumn.Text = "Edit";
                    editButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridViewCars.Columns.Add(editButtonColumn);
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

        private void DataGridViewCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCars.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                // Handle the "Edit" button click
                int carID = Convert.ToInt32(dataGridViewCars.Rows[e.RowIndex].Cells["CarID"].Value);
                EditCar(carID);
            }
        }

        private void EditCar(int carID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Car WHERE CarID = @CarID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CarID", carID);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtModel.Text = reader["Model"].ToString();
                        txtManufacturer.Text = reader["Manufacturer"].ToString();
                        txtYear.Text = reader["Year"].ToString();
                        txtPrice.Text = reader["Price"].ToString();
                        txtDescription.Text = reader["Description"].ToString();
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string model = txtModel.Text;
            string manufacturer = txtManufacturer.Text;
            int year = int.Parse(txtYear.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            string description = txtDescription.Text;
            int carID = Convert.ToInt32(dataGridViewCars.CurrentRow.Cells["CarID"].Value);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Car SET Model = @Model, Manufacturer = @Manufacturer, Year = @Year, Price = @Price, Description = @Description WHERE CarID = @CarID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Model", model);
                    command.Parameters.AddWithValue("@Manufacturer", manufacturer);
                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@CarID", carID);

                    connection.Open();
                    command.ExecuteNonQuery();
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

            LoadCarData();
            MessageBox.Show("Car details updated successfully!");
        }
    }
}
