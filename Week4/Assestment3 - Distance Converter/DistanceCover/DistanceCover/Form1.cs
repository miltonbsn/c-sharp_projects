using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceCover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String input = inputDistancetextBox.Text;
            double fromDistance;
            double outputDistance = 0.0;

            if (double.TryParse(input, out fromDistance))
            {


                if (fromListBox.SelectedItem != null && toListBox.SelectedItem != null)
                {

                    String fromUnit = fromListBox.SelectedItem.ToString();
                    String toUnit = toListBox.SelectedItem.ToString();
                    switch (fromUnit)
                    {
                        case "Inches":

                            switch (toUnit)
                            {
                                case "Inches":
                                    MessageBox.Show("You have selected the same unit. Please select another one.");
                                    outputDistance = fromDistance;
                                    break;

                                case "Feet":
                                    outputDistance = fromDistance * 0.0833333;
                                    break;

                                case "Yards":
                                    outputDistance = fromDistance * 0.0277778;
                                    break;
                            }

                            break;

                        case "Feet":

                            switch (toUnit)
                            {
                                case "Inches":
                                    outputDistance = fromDistance * 12;
                                    break;

                                case "Feet":
                                    MessageBox.Show("You have selected the same unit. Please select another one.");
                                    outputDistance = fromDistance;
                                    break;

                                case "Yards":
                                    outputDistance = fromDistance * 0.333333;
                                    break;
                            }

                            break;

                        case "Yards":
                            switch (toUnit)
                            {
                                case "Inches":
                                    outputDistance = fromDistance * 36;
                                    break;

                                case "Feet":
                                    outputDistance = fromDistance * 3;
                                    break;

                                case "Yards":
                                    MessageBox.Show("You have selected the same unit. Please select another one.");
                                    outputDistance = fromDistance;
                                    break;
                            }
                            break;
                    }

                    distanceConvertedLabel.Text = outputDistance.ToString();
                }
                else
                {
                    MessageBox.Show("Please select From and To units.");
                }

            }
            else
            {
                MessageBox.Show("Invalid input for distance.");
            }



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
