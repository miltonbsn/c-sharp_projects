using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            largestTextBox.Text = "";
            smallestTextBox.Text = "";
            avarageTextBox.Text = "";
            totalTextBox.Text = "";
            listBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

            try
            {
                StreamReader inputFile;

                String value;

                List<double> values = new List<double>();

                inputFile = File.OpenText("Sales.txt");

                while (!inputFile.EndOfStream)
                {
                    value = inputFile.ReadLine();

                    listBox.Items.Add(value);

                    values.Add(double.Parse(value));

                }

                calculateTotal(values);
                calculateAvarage(values);
                calculateSmallest(values);
                calculateLargest(values);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateAvarage(List<double> values)
        {
            double total = 0.0;
            double avarage = 0.0;

            foreach (double value in values)
            {
                total = total + value;
            }

            avarage = total / values.Count();

            avarageTextBox.Text = avarage.ToString();
        }

        private void calculateSmallest(List<double> values)
        {
            double smallest = double.MaxValue;

            foreach (double value in values)
            {
                if (value < smallest)
                {
                    smallest = value;
                }
            }
            smallestTextBox.Text = smallest.ToString();
        }

        private void calculateLargest(List<double> values)
        {
            double largest = 0.0;

            foreach (double value in values)
            {
                if (value > largest)
                {
                    largest = value;
                }
            }
            largestTextBox.Text = largest.ToString();
        }

        private void calculateTotal(List<double> values)
        {
            double total = 0.0;
            
            foreach (double value in values)
            {
                total = total + value;
            }

            totalTextBox.Text = total.ToString();
        }
    }
}
