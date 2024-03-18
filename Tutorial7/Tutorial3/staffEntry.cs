using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tutorial3
{

    public partial class staffEntry : Form
    {
        public List<StaffData> staffData { get; set; }
        private List<StaffData> staffList = new List<StaffData>();
        private string selectedImagePath = null; // set the image path
        private int age; // Declare age variable
        private int staffCounter = 1; // Initialize staff counter

        private bool updatingMode = false; // Flag to indicate whether the form is in update mode
        private int rowIndexToUpdate = -1;

        private int currentPage = 1;
        private int pageSize = 10; // Number of rows per page

        // Connection string
        string connectionString = @"Data Source=DESKTOP-ET26M53\SQLEXPRESS;Initial Catalog=staffData;Integrated Security=True;User ID=sa;Password=root;";

        public staffEntry()
        {
            InitializeComponent();
            PopulateDataGridViewFromDatabase();
            dataGridView.ReadOnly = true;

            // Set the maximum length for txtStaffName to 50 characters
            txtStaffName.MaxLength = 50;

            // Set the maximum length for txtNrcNo to 15 characters
            txtNrcNo.MaxLength = 15;

            // Set the maximum length for txtPhoneone and txtPhonetwo to 15 characters each
            txtPhoneone.MaxLength = 15;
            txtPhonetwo.MaxLength = 15;

            // Set the maximum length for the address RichTextBox to 200 characters
            rtxtAddress.MaxLength = 200;

            // Maximize the form
            this.WindowState = FormWindowState.Maximized;
        }

        private void PopulateDataGridViewFromDatabase()
        {
            try
            {
                // Create connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open connection
                    connection.Open();

                    // Calculate offset based on current page and page size
                    int offset = (currentPage - 1) * pageSize;

                    // Retrieve data with pagination
                    string query = $"SELECT * FROM staffTable WHERE is_deleted = 0 ORDER BY staff_no OFFSET {offset} ROWS FETCH NEXT {pageSize} ROWS ONLY";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind data to DataGridView
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the file dialog properties
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Title = "Select Desired Image";

                // Show the file dialog
                DialogResult result = openFileDialog.ShowDialog();


                // get gender data from radio button
                string selectedGender = "";

                // Check if the user selected a file
                if (result == DialogResult.OK)
                {
                    // Get the selected file path
                    selectedImagePath = openFileDialog.FileName;

                    try
                    {
                        // Display the selected image in the PictureBox
                        pictureBoxPreview.Image = Image.FromFile(selectedImagePath);
                        pictureBoxPreview.SizeMode = PictureBoxSizeMode.StretchImage; // fix the image in preview
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoOther.Checked = true; // Set "Other" radio button checked by default
            cbStaffType.SelectedIndex = 0; // set full time to be default
            btnDelete.Visible = false; // delte button hide at start
        }

        // Method to calculate age from date of birth
        private bool IsNameValid(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

        private bool IsJoinFromValid(DateTime joinFrom)
        {
            // Add your custom validation logic here if needed
            return true;
        }

        private bool IsDobValid(DateTime dob)
        {
            // Add your custom validation logic here if needed
            return true;
        }

        private bool IsStaffTypeValid(string staffType)
        {
            // Add your custom validation logic here if needed
            return !string.IsNullOrWhiteSpace(staffType);
        }

        private bool IsNrcNoValid(string nrcNo)
        {
            // Add your custom validation logic here if needed
            return !string.IsNullOrWhiteSpace(nrcNo);
        }

        private bool IsPhoneNoValid(string phoneNo)
        {
            // Add your custom validation logic here if needed
            return !string.IsNullOrWhiteSpace(phoneNo);
        }

        private bool ValidateInputFields()
        {
            if (!IsNameValid(txtStaffName.Text))
            {
                MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsJoinFromValid(txtJoinFrom.Value))
            {
                MessageBox.Show("Please enter a valid Join From date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsDobValid(txtDob.Value))
            {
                MessageBox.Show("Please enter a valid Date of Birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsStaffTypeValid(cbStaffType.Text))
            {
                MessageBox.Show("Please select a valid Staff Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsNrcNoValid(txtNrcNo.Text))
            {
                MessageBox.Show("Please enter a valid NRC No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsPhoneNoValid(txtPhoneone.Text))
            {
                MessageBox.Show("Please enter a valid Phone No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private int GetSelectedGender()
        {
            if (rdoMale.Checked)
            {
                return 1; // Male
            }
            else if (rdoFemale.Checked)
            {
                return 2; // Female
            }
            else
            {
                return 0; // Other
            }
        }

        private int GetSelectedStaffType()
        {
            if (cbStaffType.Text == "Full Time")
            {
                return 1; // Full Time
            }
            else
            {
                return 2; // Part Time
            }
        }


        private int CalculateAge(DateTime dob)
        {
            // Calculate age from date of birth
            int age = DateTime.Today.Year - dob.Year;
            if (dob.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        private void ClearInputFields()
        {
            // Clear all input fields
            txtStaffNo.Clear();
            txtStaffName.Clear();
            txtJoinFrom.Value = DateTime.Now;
            txtDob.Value = DateTime.Now;
            txtAge.Clear();
            cbStaffType.SelectedIndex = -1;
            txtNrcNo.Clear();
            rdoOther.Checked = false;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtPhoneone.Clear();
            txtPhonetwo.Clear();
            pictureBoxPreview.Image = null;
            selectedImagePath = null;
            rtxtAddress.Clear();

            cbStaffType.SelectedIndex = 0; // set full time to be default
        }

        private void PopulateInputFields(int rowIndex)
        {
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            // Populate input fields with data from the selected row
            txtStaffNo.Text = selectedRow.Cells["colStaffNo"].Value.ToString();
            txtStaffName.Text = selectedRow.Cells["colStaffName"].Value.ToString();
            txtJoinFrom.Value = Convert.ToDateTime(selectedRow.Cells["colJoinFrom"].Value);
            txtDob.Value = Convert.ToDateTime(selectedRow.Cells["colJoinFrom"].Value);
            txtAge.Text = selectedRow.Cells["colAge"].Value.ToString();
            cbStaffType.Text = selectedRow.Cells["StaffType"].Value.ToString();
            txtNrcNo.Text = selectedRow.Cells["colNRCNo"].Value.ToString();
            string gender = selectedRow.Cells["colGender"].Value.ToString();
            if (gender == "Male")
                rdoMale.Checked = true;
            else if (gender == "Female")
                rdoFemale.Checked = true;
            else
                rdoOther.Checked = true;
            txtPhoneone.Text = selectedRow.Cells["colPhoneNo1"].Value.ToString();
            txtPhonetwo.Text = selectedRow.Cells["colPhoneNo2"].Value.ToString();
            pictureBoxPreview.Image = (Image)selectedRow.Cells["colImage"].Value;
            rtxtAddress.Text = selectedRow.Cells["colAddress"].Value.ToString();
        }

        //change to update when a row is selected
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Set the form to update mode
                updatingMode = true;

                // Get the index of the selected row
                int rowIndex = dataGridView.SelectedRows[0].Index;

                // Retrieve the DataRow from the DataTable bound to the DataGridView
                DataRow selectedRow = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;

                // Populate input fields with data from the selected row
                txtStaffNo.Text = selectedRow["staff_no"].ToString();
                txtStaffName.Text = selectedRow["staff_name"].ToString();
                txtJoinFrom.Value = Convert.ToDateTime(selectedRow["join_from"]);
                txtDob.Value = Convert.ToDateTime(selectedRow["dob"]);
                cbStaffType.Text = selectedRow["staff_type"].ToString();
                txtNrcNo.Text = selectedRow["nrc_number"].ToString();
                string gender = selectedRow["gender"].ToString();
                if (gender == "1")
                    rdoMale.Checked = true;
                else if (gender == "2")
                    rdoFemale.Checked = true;
                else
                    rdoOther.Checked = true;
                txtPhoneone.Text = selectedRow["phone_no_1"].ToString();
                txtPhonetwo.Text = selectedRow["phone_no_2"].ToString();

                // Load image from file path if available
                string imagePath = selectedRow["photo"].ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBoxPreview.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBoxPreview.Image = null;
                }

                rtxtAddress.Text = selectedRow["address"].ToString();

                // Show the delete button
                btnDelete.Visible = true;

                // Set rowIndexToUpdate
                rowIndexToUpdate = rowIndex;
            }
            else
            {
                updatingMode = false;

                // Clear input fields
                ClearInputFields();

                // Hide the delete button
                btnDelete.Visible = false;
            }
        }

        private void AddData()
        {
            // Validate input fields before adding data
            if (!ValidateInputFields())
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determine the selected gender
            int selectedGender = GetSelectedGender();

            // Determine the selected staff type
            int selectedStaffType = GetSelectedStaffType();

            // Calculate age from date of birth
            int age = CalculateAge(txtDob.Value);

            // Check if age is valid (not 0)
            if (age == 0)
            {
                MessageBox.Show("Please enter a valid date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Define the path of the image
            string imagePath = selectedImagePath ?? ""; // Use selectedImagePath if not null, otherwise empty string

            // Define your SQL INSERT query with parameters
            string addQuery = @"INSERT INTO staffTable (staff_no, staff_name, join_from, dob, staff_type, nrc_number, gender, phone_no_1, phone_no_2, photo, address, is_deleted)
                        VALUES (@StaffNo, @StaffName, @JoinFrom, @Dob, @StaffType, @NRCNo, @Gender, @PhoneNo1, @PhoneNo2, @ImagePath, @Address, @IsDeleted)";

            // Create a SQL connection and command objects
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand with the query and connection
                using (SqlCommand command = new SqlCommand(addQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@StaffNo", txtStaffNo.Text);
                    command.Parameters.AddWithValue("@StaffName", txtStaffName.Text);
                    command.Parameters.AddWithValue("@JoinFrom", txtJoinFrom.Value);
                    command.Parameters.AddWithValue("@Dob", txtDob.Value);
                    command.Parameters.AddWithValue("@StaffType", selectedStaffType);
                    command.Parameters.AddWithValue("@NRCNo", txtNrcNo.Text);
                    command.Parameters.AddWithValue("@Gender", selectedGender);
                    command.Parameters.AddWithValue("@PhoneNo1", txtPhoneone.Text);
                    command.Parameters.AddWithValue("@PhoneNo2", txtPhonetwo.Text);
                    command.Parameters.AddWithValue("@ImagePath", imagePath);
                    command.Parameters.AddWithValue("@Address", rtxtAddress.Text);
                    command.Parameters.AddWithValue("@IsDeleted", 0); // Set is_deleted to 0 by default

                    // Open the connection
                    connection.Open();

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally, clear input fields after adding
                        ClearInputFields();

                        // Refresh the DataGridView to reflect the changes
                        PopulateDataGridViewFromDatabase();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void UpdateData()
        {
            // Validate input fields before updating data
            if (!ValidateInputFields())
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determine the selected gender
            int selectedGender = GetSelectedGender();

            // Determine the selected staff type
            int selectedStaffType = GetSelectedStaffType();

            // Calculate age from date of birth
            int age = CalculateAge(txtDob.Value);

            // Check if age is valid (not 0)
            if (age == 0)
            {
                MessageBox.Show("Please enter a valid date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the ID of the selected row
            int selectedRowID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["id"].Value);

            // Define your SQL UPDATE query
            string updateQuery = @"UPDATE staffTable 
                           SET staff_no = @StaffNo, staff_name = @StaffName, join_from = @JoinFrom, 
                               dob = @Dob, staff_type = @StaffType, nrc_number = @NRCNo, 
                               gender = @Gender, phone_no_1 = @PhoneNo1, phone_no_2 = @PhoneNo2, 
                               photo = @ImagePath, address = @Address
                           WHERE id = @ID";

            // Create a SQL connection and command objects
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand with the query and connection
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@StaffNo", txtStaffNo.Text);
                    command.Parameters.AddWithValue("@StaffName", txtStaffName.Text);
                    command.Parameters.AddWithValue("@JoinFrom", txtJoinFrom.Value);
                    command.Parameters.AddWithValue("@Dob", txtDob.Value);
                    command.Parameters.AddWithValue("@StaffType", selectedStaffType);
                    command.Parameters.AddWithValue("@NRCNo", txtNrcNo.Text);
                    command.Parameters.AddWithValue("@Gender", selectedGender);
                    command.Parameters.AddWithValue("@PhoneNo1", txtPhoneone.Text);
                    command.Parameters.AddWithValue("@PhoneNo2", txtPhonetwo.Text);
                    command.Parameters.AddWithValue("@ImagePath", selectedImagePath ?? ""); // Use selectedImagePath if not null, otherwise empty string
                    command.Parameters.AddWithValue("@Address", rtxtAddress.Text);
                    command.Parameters.AddWithValue("@ID", selectedRowID); // Use the ID of the selected row for updating

                    // Open the connection
                    connection.Open();

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally, clear input fields after updating
                        ClearInputFields();

                        // Refresh the DataGridView to reflect the changes
                        PopulateDataGridViewFromDatabase();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (updatingMode)
            {
                // If in update mode, perform update operation
                UpdateData();
            }
            else
            {
                // If not in update mode, perform add operation
                AddData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields(); // clear input fields
            btnDelete.Visible = false; // delete button hide
            updatingMode = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if the form is in update mode
            if (updatingMode && rowIndexToUpdate >= 0)
            {
                // Optionally, prompt the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    int selectedRowID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["id"].Value);

                    // Define your SQL UPDATE query to set is_deleted to 1
                    string updateQuery = @"UPDATE staffTable 
                                   SET is_deleted = 1
                                   WHERE id = @ID";

                    // Create a SQL connection and command objects
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Create a SqlCommand with the query and connection
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Add parameter to the command
                            command.Parameters.AddWithValue("@ID", selectedRowID); // Use the ID of the selected row for updating

                            // Open the connection
                            connection.Open();

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check if any rows were affected
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data marked as deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Optionally, clear input fields after marking as deleted
                                ClearInputFields();

                                // Refresh the DataGridView to reflect the changes
                                PopulateDataGridViewFromDatabase();
                            }
                            else
                            {
                                MessageBox.Show("Failed to mark data as deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    // Reset update mode
                    updatingMode = false;
                    rowIndexToUpdate = -1;
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            PopulateDataGridViewFromDatabase();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                PopulateDataGridViewFromDatabase();
            }
        }

        private void staffListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the login form
            staffListing form1 = new staffListing();
            form1.ShowDialog(); // Show Form1 as a dialog
            this.Close(); // Close the login form
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the login form
            login form2 = new login();
            form2.ShowDialog(); // Show Form1 as a dialog
            this.Close(); // Close the login form
        }
    }
}
