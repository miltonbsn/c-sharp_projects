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

namespace RandomNumberFileWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            String numberTXT = numebersTextBox.Text;
            int numbers = 0;
            SaveFileDialog saveFile = new SaveFileDialog();

            if(int.TryParse(numberTXT, out numbers)){

                try
                {
                    saveFile.InitialDirectory = "Libraries/Documents";

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter outputFile;

                        outputFile = File.CreateText(saveFile.FileName);

                        int number;

                        Random rand = new Random();

                        for (int count = 1; count <= numbers; count++)
                        {
                            number = rand.Next(100);

                            outputFile.WriteLine(number);
                        }
                        outputFile.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            } else {
                MessageBox.Show("Please, choose a number");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numebersTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
