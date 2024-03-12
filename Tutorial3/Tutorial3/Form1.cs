using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tutorial3
{

    public partial class Form1 : Form
    {
        public List<StaffData> staffData { get; set; }
        private List<StaffData> staffList = new List<StaffData>();
        private string selectedImagePath = null; // set the image path
        private int age; // Declare age variable
        private int staffCounter = 1; // Initialize staff counter

        private bool updatingMode = false; // Flag to indicate whether the form is in update mode
        private int rowIndexToUpdate = -1;

        public Form1()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {


            // Set the colImage column as a DataGridViewImageColumn
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "colImage";
            imageColumn.HeaderText = "Image";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.DefaultCellStyle.NullValue = null;

            // Add columns to the DataGridView
            dataGridView.Columns.Add("colStaffNo", "Staff No.");
            dataGridView.Columns.Add(imageColumn);
            dataGridView.Columns.Add("colStaffName", "Staff Name");
            dataGridView.Columns.Add("colJoinFrom", "Join From");
            dataGridView.Columns.Add("StaffType", "Staff Type");
            dataGridView.Columns.Add("colNRCNo", "NRC No.");
            dataGridView.Columns.Add("colGender", "Gender");
            dataGridView.Columns.Add("colAge", "Age");
            dataGridView.Columns.Add("colPhoneNo1", "Phone No.");
            dataGridView.Columns.Add("colPhoneNo2", "Phone No.");
            dataGridView.Columns.Add("colAddress", "Address");

            
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

        }

        // Method to calculate age from date of birth
        private bool ValidateInputFields()
        {
            if (string.IsNullOrEmpty(txtStaffName.Text) || string.IsNullOrEmpty(txtNrcNo.Text) || 
                string.IsNullOrEmpty(txtJoinFrom.Text) || string.IsNullOrEmpty(txtDob.Text) ||
                string.IsNullOrEmpty(cbStaffType.Text) || string.IsNullOrEmpty(txtNrcNo.Text) ||
                string.IsNullOrEmpty(txtPhoneone.Text))
                 return false;
            else
                return true;
        }

        private string GetSelectedGender()
        {
            // Determine the selected gender based on radio button selection
            if (rdoOther.Checked)
                return "Other";
            else if (rdoMale.Checked)
                return "Male";
            else if (rdoFemale.Checked)
                return "Female";
            else
                return "";
        }

        private int CalculateAge(DateTime dob)
        {
            // Calculate age from date of birth
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age))
                age--;
            return age;
        }

        private void ClearInputFields()
        {
            // Clear all input fields
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
                rowIndexToUpdate = dataGridView.SelectedRows[0].Index;

                // Populate input fields with data from the selected row
                PopulateInputFields(rowIndexToUpdate);
            }
        }

        private void AddData()
        {

            // Validate input fields before adding data
            if (string.IsNullOrEmpty(txtStaffName.Text) ||
                string.IsNullOrEmpty(txtJoinFrom.Text) ||
                string.IsNullOrEmpty(txtDob.Text) ||
                string.IsNullOrEmpty(cbStaffType.Text) ||
                string.IsNullOrEmpty(txtNrcNo.Text) ||
                string.IsNullOrEmpty(txtPhoneone.Text))
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determine the selected gender
            string selectedGender = GetSelectedGender();

            // Calculate age from date of birth
            int age = CalculateAge(txtDob.Value);

            // Create a new StaffData object with input field values
            StaffData newStaff = new StaffData
            {
                txtStaffNo = staffCounter++,
                txtStaffName = txtStaffName.Text,
                txtJoinFrom = txtJoinFrom.Value,
                txtDob = txtDob.Value,
                txtAge = age,
                cbStaffType = cbStaffType.Text,
                txtNrcNo = txtNrcNo.Text,
                gender = selectedGender,
                txtPhoneone = txtPhoneone.Text,
                txtPhonetwo = txtPhonetwo.Text,
                Image = Image.FromFile(selectedImagePath),
                rtxtAddress = rtxtAddress.Text
            };

            // Add the new staff to the list
            staffList.Add(newStaff);

            // Add a new row to the DataGridView and populate it with staff data
            dataGridView.Rows.Add(new object[] {
                newStaff.txtStaffNo,
                newStaff.Image,
                newStaff.txtStaffName,
                newStaff.txtJoinFrom,
                newStaff.cbStaffType,
                newStaff.txtNrcNo,
                newStaff.gender,
                newStaff.txtAge,
                newStaff.txtPhoneone,
                newStaff.txtPhonetwo,
                newStaff.rtxtAddress
            });

            // Optionally, clear input fields after adding
            ClearInputFields();
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
            string selectedGender = GetSelectedGender();

            // Calculate age from date of birth
            int age = CalculateAge(txtDob.Value);

            // Update the corresponding StaffData object in the list with input field values
            StaffData updatedStaff = staffList[rowIndexToUpdate];
            updatedStaff.txtStaffName = txtStaffName.Text;
            updatedStaff.txtJoinFrom = txtJoinFrom.Value;
            updatedStaff.txtDob = txtDob.Value;
            updatedStaff.txtAge = age;
            updatedStaff.cbStaffType = cbStaffType.Text;
            updatedStaff.txtNrcNo = txtNrcNo.Text;
            updatedStaff.gender = selectedGender;
            updatedStaff.txtPhoneone = txtPhoneone.Text;
            updatedStaff.txtPhonetwo = txtPhonetwo.Text;
            updatedStaff.Image = Image.FromFile(selectedImagePath);
            updatedStaff.rtxtAddress = rtxtAddress.Text;

            // Update the corresponding row in the DataGridView with updated staff data
            dataGridView.Rows[rowIndexToUpdate].SetValues(new object[] {
                updatedStaff.txtStaffNo,
                updatedStaff.Image,
                updatedStaff.txtStaffName,
                updatedStaff.txtJoinFrom,
                updatedStaff.cbStaffType,
                updatedStaff.txtNrcNo,
                updatedStaff.gender,
                updatedStaff.txtAge,
                updatedStaff.txtPhoneone,
                updatedStaff.txtPhonetwo,
                updatedStaff.rtxtAddress
            });

            // Reset update mode and clear input fields
            updatingMode = false;
            ClearInputFields();
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
                    // Remove the selected row from the DataGridView
                    dataGridView.Rows.RemoveAt(rowIndexToUpdate);

                    // Remove the corresponding data from datagridview
                    staffList.RemoveAt(rowIndexToUpdate);

                    // Clear input fields after delete
                    ClearInputFields();

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
    }
}
