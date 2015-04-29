using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTest1_FatPercentageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            String totalCaloriesText = totalCaloriesTextBox.Text;
            String fatGramsText = fatGramsTextBox.Text;

            double totalCalories;
            double fatgrams;
            double caloriesFromFat;
            double percentageFromFat;

            if (double.TryParse(totalCaloriesText, out totalCalories) && double.TryParse(fatGramsText, out fatgrams))
            {
                caloriesFromFat = calculateCaloriesFromFat(fatgrams);
                percentageFromFat = calculatePercentageFromFat(caloriesFromFat, totalCalories);

                if (valueAreValid(totalCalories, fatgrams, caloriesFromFat))
                {
                    String output = generateStringOutput(lowFatCheckBox.Checked, percentageFromFat, caloriesFromFat);
                    outputRichTextBox.Text = output;
                }

            }
            else
            {
                MessageBox.Show("Please, enter a valid number for calories and fat grams!");
            }
        }

        private bool valueAreValid(double totalCalories, double fatgrams, double caloriesFromFat)
        {
            if (totalCalories < 0)
            {
                MessageBox.Show("Sorry, total calories can't be less than 0!");
                return false;
            } 

            if (fatgrams < 0)
            {
                MessageBox.Show("Sorry, fatgrams can't be less than 0!");
                return false;
            }

            if (caloriesFromFat > totalCalories)
            {
                MessageBox.Show("Sorry, calories From Fat can't be less than total calories");
                return false;
            } 

            return true;
        }

        private string generateStringOutput(bool lowFatChecked, double percentageFromFat, double caloriesFromFat)
        {

            String output = "Calories from fat: " + caloriesFromFat + "\nPercentage of calories from fat: " + percentageFromFat.ToString("0.0%");
            if (lowFatChecked)
            {
                if (percentageFromFat < 0.3)
                {
                    output = output + " (low fat food)";
                }
            }

            return output;
        }


        private bool valueAreValid()
        {


            return true;
        }

        private double calculateCaloriesFromFat(double fatgrams)
        {
            return fatgrams * 9;
        }

        private double calculatePercentageFromFat(double caloriesFromFat, double totalCalories)
        {
            return caloriesFromFat / totalCalories;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Text = "";
            totalCaloriesTextBox.Text = "";
            fatGramsTextBox.Text = "";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
