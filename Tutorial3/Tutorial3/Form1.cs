using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial3
{

    public partial class Form1: Form
    {
        public List<StaffData> staffData { get; set; }
        private List<StaffData> staffList = new List<Staff>();
        private string selectedImagePath = null; // set the image path

        public Form1()
        {
            InitializeComponent();
            InitializeStaffList();
            PopulateDataGridView();
        }

        private void InitializeStaffList()
        {
            // Populate staffList with sample data
            staffList.Add(new Staff
            {
                StaffNo = 1,
                // Assuming you have the image path or image object
                // Replace "imagePath1" with your actual image path or provide an Image object
                Image = Image.FromFile("imagePath1"),
                StaffName = "John Doe",
                JoinFrom = new DateTime(2022, 1, 1),
                StaffType = "Full-time",
                NRCNo = "12345",
                Gender = "Male",
                Age = 30,
                PhoneNo1 = "123456789",
                PhoneNo2 = "987654321",
                Address = "123 Main St, City"
            });

            // Add more sample staff data if needed
        }

        private void PopulateDataGridView()
        {
            // Add columns to the DataGridView
            dataGridView.Columns.Add("StaffNo", "Staff No.");
            dataGridView.Columns.Add("Image", "Image");
            dataGridView.Columns.Add("StaffName", "Staff Name");
            dataGridView.Columns.Add("JoinFrom", "Join From");
            dataGridView.Columns.Add("StaffType", "Staff Type");
            dataGridView.Columns.Add("NRCNo", "NRC No.");
            dataGridView.Columns.Add("Gender", "Gender");
            dataGridView.Columns.Add("Age", "Age");
            dataGridView.Columns.Add("PhoneNo1", "Phone No.");
            dataGridView.Columns.Add("PhoneNo2", "Phone No.");
            dataGridView.Columns.Add("Address", "Address");
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

                // Check if the user selected a file
                if (result == DialogResult.OK)
                {
                    // Get the selected file path
                    selectedImagePath = openFileDialog.FileName;

                    // Display the selected image in the PictureBox
                    pictureBoxPreview.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
