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
        private TextBox txtSearch;
        private Button btnSave;
        private Label lblModel;
        private Label lblManufacturer;
        private Label lblYear;
        private Label lblPrice;
        private Label lblDescription;
        private Label lblSearch;

        private string connectionString = "Data Source=CHAMODH792\\SQLEXPRESS;Initial Catalog=ABCTradersDB;Integrated Security=True;Encrypt=False";
        private int? editCarID = null;

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
                    if (!dataGridViewCars.Columns.Contains("Edit"))
                    {
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "Edit",
                            Text = "Edit",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridViewCars.Columns.Add(editButtonColumn);
                    }

                    // Add "Delete" button column
                    if (!dataGridViewCars.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "Delete",
                            Text = "Delete",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridViewCars.Columns.Add(editButtonColumn);
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
         "Model LIKE '%{0}%' OR Manufacturer LIKE '%{0}%' OR CONVERT(Year, System.String) LIKE '%{0}%' OR CONVERT(Price, System.String) LIKE '%{0}%' OR Description LIKE '%{0}%'",
         filterText);
            (dataGridViewCars.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void DataGridViewCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridViewCars.Columns["Edit"].Index)
                {
                    // Handle the "Edit" button click
                    editCarID = Convert.ToInt32(dataGridViewCars.Rows[e.RowIndex].Cells["CarID"].Value);
                    LoadCarDetails(editCarID.Value);
                    btnSave.Text = "Edit";
                }
                else if (e.ColumnIndex == dataGridViewCars.Columns["Delete"].Index)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this car?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Handle the "Delete" button click
                        int carID = Convert.ToInt32(dataGridViewCars.Rows[e.RowIndex].Cells["CarID"].Value);
                        DeleteCar(carID);
                    }
                }
            }
        }

        private void LoadCarDetails(int carID)
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
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSaveOrEdit_Click(object sender, EventArgs e)
        {
            if (editCarID.HasValue)
            {
                // Edit existing record
                UpdateCar(editCarID.Value);
                editCarID = null; // Reset edit mode
            }
            else
            {
                // Add new record
                AddNewCar();
            }

            LoadCarData(); // Refresh the table
        }

        private void AddNewCar()
        {
            string model = txtModel.Text;
            string manufacturer = txtManufacturer.Text;
            int year = int.Parse(txtYear.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            string description = txtDescription.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Car (Model, Manufacturer, Year, Price, Description) VALUES (@Model, @Manufacturer, @Year, @Price, @Description)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Model", model);
                    command.Parameters.AddWithValue("@Manufacturer", manufacturer);
                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Description", description);

                    connection.Open();
                    int row = command.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Car added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            ClearTextFields(); // Clear fields after adding a new car
        }

        private void UpdateCar(int carID)
        {
            string model = txtModel.Text;
            string manufacturer = txtManufacturer.Text;
            int year = int.Parse(txtYear.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            string description = txtDescription.Text;

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
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Car Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            ClearTextFields(); // Clear fields after editing a car
        }

        private void DeleteCar(int carID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Car WHERE CarID = @CarID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CarID", carID);

                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Car record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                LoadCarData(); // Refresh the table after deletion
                ClearTextFields();
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

        private void ClearTextFields()
        {
            txtModel.Clear();
            txtManufacturer.Clear();
            txtYear.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
            editCarID = null; // Reset edit mode
            btnSave.Text = "Save"; // Reset button text to "Save"
        }
    }
}
