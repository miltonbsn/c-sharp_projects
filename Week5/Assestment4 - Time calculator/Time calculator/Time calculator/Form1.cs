using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_calculator
{
    public partial class timeCalculatorForm : Form
    {
        public timeCalculatorForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputSecondsTextBox.Text = "";
            DisplayHours.Text = "";
            displayMinutes.Text = "";
            displayDays.Text = "";
            displayTotal.Text = "";
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                String secondsText = inputSecondsTextBox.Text;
                long totalSeconds;
                if (long.TryParse(secondsText, out totalSeconds))
                {
                    int days = 0;
                    int hours = 0;
                    int minutes = 0;
                    int seconds = 0;

                    if (totalSeconds >= 86400)
                    {
                        days = (int)totalSeconds / 86400;
                        displayDays.Text = days.ToString();
                    }

                    if (totalSeconds >= 3600)
                    {
                        hours = (int)totalSeconds / 3600;
                        DisplayHours.Text = hours.ToString();
                    }

                    if (totalSeconds >= 60)
                    {
                        minutes = (int)totalSeconds / 60;
                        displayMinutes.Text = minutes.ToString();
                    }

                    if (totalSeconds >= 86400)
                    {
                        totalSeconds = totalSeconds % 86400;
                    }

                    hours = (int)totalSeconds / 3600;
                    minutes = (int)(totalSeconds % 3600) / 60;
                    seconds = (int)totalSeconds % 60;

                    displayTotal.Text = days.ToString() + " day(s)  " + hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();

                }
                else
                {
                    MessageBox.Show("Please, enter a valid number for seconds!");
                }

            }
            catch 
            {
                MessageBox.Show("Sorry, somothing is wrong!");
            }
        }
    }
}
