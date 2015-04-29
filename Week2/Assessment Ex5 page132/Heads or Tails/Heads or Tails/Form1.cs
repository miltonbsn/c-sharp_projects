using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_Tails
{
    public partial class HeadorTail : Form
    {
        public HeadorTail()
        {
            InitializeComponent();
        }

        private void showHeadsButton_Click(object sender, EventArgs e)
        {
            headPictureBox.Visible = true;
            tailPictureBox.Visible = false;
        }

        private void showTailsButton_Click(object sender, EventArgs e)
        {
            headPictureBox.Visible = false;
            tailPictureBox.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
