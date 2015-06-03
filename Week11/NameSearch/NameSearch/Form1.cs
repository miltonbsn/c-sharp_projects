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

namespace NameSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> boys = new List<string>();
                List<string> girls = new List<string>();

                loadList(boys, "BoyNames.txt");
                loadList(girls, "GirlNames.txt");

                string name = nameTextBox.Text;

                if (serchName(name, boys, girls))
                {
                    resultLabel.Text = "Yes, the name is there :D";
                    resultLabel.ForeColor = Color.Green;
                }
                else
                {
                    resultLabel.Text = "No, the name is not there ;(";
                    resultLabel.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool serchName(string name, List<string> boys, List<string> girls)
        {
            if (boys.Contains(name))
            {
                return true;
            }

            if (girls.Contains(name))
            {
                return true;
            }

            return false;
        }

        private void loadList(List<string> list, string fileName)
        {
            StreamReader inputFile;

            inputFile = File.OpenText(fileName);

            while (!inputFile.EndOfStream)
            {
                list.Add(inputFile.ReadLine());
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            resultLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
