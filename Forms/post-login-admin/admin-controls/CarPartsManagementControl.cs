using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ABCTradersApp.forms;

namespace ABCTradersApp.Forms.post_login_admin.admin_controls
{
    public partial class CarPartsManagementControl : UserControl
    {
        private TextBox txtPartName;
        private TextBox txtPartNumber;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtSearch;
        private Label lblPartName;
        private Label lblPartNumber;
        private Label lblPrice;
        private Button btnSave;
        private Label lblQuantity;
        private TextBox txtQuatity;
        private GroupBox groupBoxSearch;
        private GroupBox groupBoxDescription;
        private GroupBox groupBoxCarPartDetails;

        private DataGridView dataGridViewCarParts;

        private string connectionString = DatabaseConfig.ConnectionString;
        private int? editCarPartID = null;

        public CarPartsManagementControl()
        {
            InitializeComponent();
            LoadCarPartsData();
        }

        private void LoadCarPartsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM CarPart";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewCarParts.DataSource = dataTable;

                    // Add "Edit" button column
                    if (!dataGridViewCarParts.Columns.Contains("Edit"))
                    {
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "Edit",
                            Text = "Edit",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridViewCarParts.Columns.Add(editButtonColumn);
                    }

                    // Add "Delete" button column
                    if (!dataGridViewCarParts.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "Delete",
                            Text = "Delete",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridViewCarParts.Columns.Add(editButtonColumn);
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
            //filter cars parts by search text
            FilterCarPartsData(txtSearch.Text);
        }

        private void FilterCarPartsData(string filterText)
        {

            //match search text with every colounm in car table 
            string rowFilter = string.Format("Convert(PartName, 'System.String') LIKE '%{0}%' OR " +
        "Convert(PartNumber, 'System.String') LIKE '%{0}%' OR " +
        "Convert(Price, 'System.String') LIKE '%{0}%' OR " +
        "Convert(Description, 'System.String') LIKE '%{0}%'",
         filterText);
            (dataGridViewCarParts.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void DataGridViewCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridViewCarParts.Columns["Edit"].Index)
                {
                    // Handle the "Edit" button click
                    editCarPartID = Convert.ToInt32(dataGridViewCarParts.Rows[e.RowIndex].Cells["CarPartID"].Value);
                    LoadCarPartDetails(editCarPartID.Value);
                    btnSave.Text = "Edit";
                }
                else if (e.ColumnIndex == dataGridViewCarParts.Columns["Delete"].Index)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this car Part?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Handle the "Delete" button click
                        int carPartID = Convert.ToInt32(dataGridViewCarParts.Rows[e.RowIndex].Cells["CarPartID"].Value);
                        DeleteCarPart(carPartID);
                    }
                }
            }
        }

        private void LoadCarPartDetails(int partID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM CarPart WHERE CarPartID = @PartID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PartID", partID);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtPartName.Text = reader["PartName"].ToString();
                        txtPartNumber.Text = reader["PartNumber"].ToString();
                        txtPrice.Text = reader["Price"].ToString();
                        txtDescription.Text = reader["Description"].ToString();
                        txtQuatity.Text = reader["Quantity"].ToString();

                        btnSave.Text = "Edit";
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
            if (editCarPartID.HasValue)
            {
                // Edit existing record
                UpdateCarPart(editCarPartID.Value);
                editCarPartID = null; // Reset edit mode
            }
            else
            {
                // Add new record
                AddNewCarPart();
            }

            LoadCarPartsData(); // Refresh the table
        }

        private void AddNewCarPart()
        {
            //validate inputh with null check and number format check
            if (ValidateInput())
            {
                string partName = txtPartName.Text;
                string partNumber = txtPartNumber.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                string description = txtDescription.Text;
                int qty = int.Parse(txtQuatity.Text);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO CarPart (PartName, PartNumber, Price, Description,Quantity) VALUES (@PartName, @PartNumber, @Price, @Description ,@Quantity )";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@PartName", partName);
                        command.Parameters.AddWithValue("@PartNumber", partNumber);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@Quantity", qty);

                        connection.Open();
                        int rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Car Part added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                ClearTextFields();
            }
           
        }

        private void UpdateCarPart(int carPartID)
        {
            //validate inputh with null check and number format check
            if (ValidateInput())
            {
                string partName = txtPartName.Text;
                string partNumber = txtPartNumber.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                string description = txtDescription.Text;
                int qty = int.Parse(txtQuatity.Text);


                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE CarPart SET PartName = @PartName, PartNumber = @PartNumber, Price = @Price, Description = @Description, Quantity = @Quantity WHERE CarPartID = @PartID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@PartName", partName);
                        command.Parameters.AddWithValue("@PartNumber", partNumber);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@Quantity", qty);
                        command.Parameters.AddWithValue("@PartID", carPartID);

                        connection.Open();
                        int rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Car Part Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                ClearTextFields();
            }
            
        }

        private void DeleteCarPart(int carPartID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM CarPart WHERE CarPartID = @PartID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PartID", carPartID);

                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Car Part record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ClearTextFields();
                LoadCarPartsData();

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

        private bool ValidateInput()
        {
            string partName = txtPartName.Text;
            string partNumber = txtPartNumber.Text;
            string priceText = txtPrice.Text;
            string description = txtDescription.Text;
            string qtyText = txtQuatity.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(partName) || string.IsNullOrWhiteSpace(partNumber) ||
                string.IsNullOrWhiteSpace(priceText) || string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(qtyText))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Price must be a valid decimal number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(qtyText, out int qty))
            {
                MessageBox.Show("Quantity must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearTextFields()
        {
            txtPartName.Text = string.Empty;
            txtPartNumber.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtQuatity.Text = string.Empty;
            editCarPartID = null; // Reset edit mode
            btnSave.Text = "Save";

        }
    }
}
