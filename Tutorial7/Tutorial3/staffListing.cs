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

namespace Tutorial3
{
    public partial class staffListing : Form
    {
        string connectionString = @"Data Source=DESKTOP-ET26M53\SQLEXPRESS;Initial Catalog=staffData;Integrated Security=True;User ID=sa;Password=root;";
        private TextBox txtSearch;

        public staffListing()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            InitializeSearchBox();
        }

        private void staffListing_Load(object sender, EventArgs e)
        {
            // Load data into DataGridView when the form is loaded
        }

        private void InitializeSearchBox()
        {
            // Initialize and configure the search TextBox
            txtSearch = new TextBox();
            txtSearch.Location = new System.Drawing.Point(50, 50); // Adjust the location as needed
            txtSearch.Size = new System.Drawing.Size(200, 20); // Adjust the size as needed
            txtSearch.TextChanged += TxtSearch_TextChanged;
            this.Controls.Add(txtSearch);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM staffTable WHERE is_deleted = 0 AND staff_name LIKE @SearchQuery";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void staffEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            staffEntry form1 = new staffEntry();
            form1.ShowDialog(); 
            this.Close(); 
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            login form2 = new login();
            form2.ShowDialog(); 
            this.Close(); 
        }
    }
}
