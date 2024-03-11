using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Attach event handlers to text boxes
            tbox_lamount.Validating += TextBox_Validating;
            tbox_intrate.Validating += TextBox_Validating;
            tbox_lduration.Validating += TextBox_Validating;
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int value;
            if (!int.TryParse(textBox.Text, out value) || value < 0)
            {
                MessageBox.Show("Please enter a valid positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                textBox.SelectAll();
                e.Cancel = true; // Cancel the focus change
            }
            else
            {
                // Perform calculation if all text boxes contain valid values
                return;
            }
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            // Declare variables
            int loanAmount, interestRate, loanDuration;

            // Get loan amount from textbox
            loanAmount = Convert.ToInt32(tbox_lamount.Text);

            // Get interest rate from textbox
            interestRate = Convert.ToInt16(tbox_intrate.Text);

            // Get loan duration from textbox
            loanDuration = Convert.ToInt16(tbox_lduration.Text);

            // Calculate interest amount
            int intAmount = ((loanAmount * interestRate) / 100) * loanDuration;

            // Calculate total amount
            int totalAmount = intAmount + loanAmount;

            // Display results
            lbl_resultinterest.Text = intAmount.ToString();
            lbl_resulttotal.Text = totalAmount.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
