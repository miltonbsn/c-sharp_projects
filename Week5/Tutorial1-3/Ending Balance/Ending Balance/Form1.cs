using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Constant for the monthly interest rate.
            const decimal INTEREST_RATE = 0.005m;

            // Local variables
            decimal balance; // The account balance
            int months; // The number of months
            int count = 1; // Loop counter, initialized with 1

            // Get the starting balance.
            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                // Get the number of months.
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    // The following loop calculates the ending balance.
                    while (count <= months)
                    {
                        // Add this month's interest to the balance.
                        balance = balance + (INTEREST_RATE * balance);

                        // Add one to the loop counter.
                        count = count + 1;
                    }

                    // Display the ending balance.
                    endingBalanceLabel.Text = balance.ToString("c");
                }
                else
                {
                    // Invalid number of months was entered.
                    MessageBox.Show("Invalid value for months.");
                }
            }
            else
            {
                // Invalid starting balance was entered.
                MessageBox.Show("Invalid value for starting balance.");
            }
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the endingBalanceLabel control.

            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";

            // Reset the focus.
            startingBalTextBox.Focus();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
