using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorThemeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yellowButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowButton.Checked){
                this.BackColor = Color.Yellow;
            }
        }

        private void redButton_CheckedChanged(object sender, EventArgs e)
        {
            if (redButton.Checked){
                this.BackColor = Color.Red;
            }

        }

        private void whiteButton_CheckedChanged(object sender, EventArgs e)
        {
            if (whiteButton.Checked)
            {
                this.BackColor = Color.White;
            }
        }

        private void normalButton_CheckedChanged(object sender, EventArgs e)
        {
            if (normalButton.Checked)
            {
                this.BackColor = SystemColors.Control;
            }
        }
    }
}
