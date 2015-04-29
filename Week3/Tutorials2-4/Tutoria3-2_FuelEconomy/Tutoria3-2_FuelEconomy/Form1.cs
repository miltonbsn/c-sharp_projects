using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutoria3_2_FuelEconomy
{
    public partial class fuelEconomyForm : Form
    {
        public fuelEconomyForm()
        {
            InitializeComponent();
        }

        private void fuelEconomyForm_Load(object sender, EventArgs e)
        {}

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles;
            double gallons;
            double mpg;

            if(double.TryParse(milesTextBox.Text, out miles)){
            // Validate the gallonsTextBox control.

                 if (double.TryParse(gallonsTextBox.Text, out gallons)){
                     // Calculate MPG.
                     mpg = miles / gallons;
                     // Display the MPG in the mpgLabel control.
                     mpgLabel.Text = mpg.ToString("n1");
                 } else {
                     // Display an error message for gallonsTextBox.
                     MessageBox.Show("Invalid input for gallons.");
                 }


            } else {
             // Display an error message for milesTextBox.
             MessageBox.Show("Invalid input for miles.");
             }

        }
    }
}



