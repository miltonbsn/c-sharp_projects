using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial3_3_SalePriceCalculator
{
    public partial class SalePriceCalculatorForm : Form
    {
        public SalePriceCalculatorForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;
            decimal discountPercentage;
            decimal discountAmount;
            decimal salePrice;

            originalPrice = decimal.Parse(originalTextBox.Text);

            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            discountPercentage = discountPercentage / 100;

            discountAmount = originalPrice * discountPercentage;

            salePrice = originalPrice - discountAmount;

            salePriceLabel.Text = salePrice.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
