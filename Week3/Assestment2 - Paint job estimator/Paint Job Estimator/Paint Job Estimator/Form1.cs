using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Job_Estimator
{
    public partial class paintJobEstimatorForm : Form
    {
        public paintJobEstimatorForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            { 
                // 1 gallon = 115 square = 8 hours labour

                double squareToBePainted = double.Parse(squareToBePaintedTextBox.Text);
                double pricePerGallon = double.Parse(pricePerGallonTextBox.Text);

                //Should I use INTEGER here? (I mean is it possible to buy 1/x gallon?)
                int gallonsRequired = (int)Math.Ceiling(squareToBePainted / 115);
                gallonsRequiredOutput.Text = gallonsRequired.ToString();
                
                double hoursRequired = ((squareToBePainted / 115) * 8);
                hoursLaborRequiredOutput.Text = hoursRequired.ToString("0.00");
                
                double paintingCost = gallonsRequired * pricePerGallon;
                paintingCostOutput.Text = paintingCost.ToString("c");

                // 1 hour labour = $20
                double laborChargeCost = (hoursRequired * 20.0);
                laborChargeOutput.Text = laborChargeCost.ToString("c");

                totalCost.Text = (laborChargeCost + paintingCost).ToString("c");

            } catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            squareToBePaintedTextBox.Text = "";
            pricePerGallonTextBox.Text = "";
            hoursLaborRequiredOutput.Text = "";
            gallonsRequiredOutput.Text = "";
            paintingCostOutput.Text = "";
            laborChargeOutput.Text = "";
            totalCost.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
