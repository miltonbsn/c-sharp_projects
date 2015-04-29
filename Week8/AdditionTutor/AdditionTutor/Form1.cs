using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionTutor
{
    public partial class AdditionTutorForm : Form
    {

        Random rand;
        int value1;
        int value2;
        int valueAnswer;

        public AdditionTutorForm()
        {
            InitializeComponent();

            messageLabel.Text = "";

            rand = new Random();
            generateNumber();

        }

        private void checkButton_Click(object sender, EventArgs e)
        {

            int.TryParse(valueAnswertextBox.Text, out valueAnswer);

            if (value1 + value2 == valueAnswer)
            {
                valueAnswertextBox.BackColor = Color.Green;
                messageLabel.Text = "Great! Keep practising.";
                messageLabel.ForeColor = Color.Green;
            }
            else
            {
                valueAnswertextBox.BackColor = Color.Red;
                messageLabel.Text ="Ow it doesn't seen rigth, try again.";
                messageLabel.ForeColor = Color.Red;
            }
        }

        private void generateNumber()
        {
            value1 = (rand.Next(100,500));
            value2 = (rand.Next(100,500));
            valeuLabel1.Text = value1.ToString();
            valueLabel2.Text = value2.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            valueAnswertextBox.BackColor = Color.White;
            messageLabel.Text = "";
            valueAnswertextBox.Text = "";
            generateNumber();
        }
    }
}
