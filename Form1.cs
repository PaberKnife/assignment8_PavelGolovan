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

namespace assignment8_PavelGolovan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool girlNameFound = false;
                bool boyNameFound = false;
                const int SIZE = 100;
                string[] girlNames = new string[SIZE];
                string[] boyNames = new string[SIZE];
                int index = 0;
                string girlName = girlTextBox.Text.ToString();
                string boyName = boyTextBox.Text.ToString();
                StreamReader inputFile;

                if (!String.IsNullOrWhiteSpace(girlTextBox.Text))
                {
                    inputFile = File.OpenText("GirlNames.txt");
                    while (!inputFile.EndOfStream && index < girlNames.Length)
                    {
                        girlNames[index] = inputFile.ReadLine();
                        index++;
                    }
                    inputFile.Close();
                    index = 0;
                }

                if (!String.IsNullOrWhiteSpace(boyTextBox.Text))
                {
                    inputFile = File.OpenText("BoyNames.txt");
                    while (!inputFile.EndOfStream && index < boyNames.Length)
                    {
                        boyNames[index] = inputFile.ReadLine();
                        index++;
                    }
                    inputFile.Close();
                    index = 0;
                }

                if (!String.IsNullOrWhiteSpace(girlTextBox.Text))
                {
                    while (!girlNameFound && index < girlNames.Length)
                    {
                        if (girlNames[index] == girlName)
                        {
                            girlNameFound = true;
                        }
                        index++;
                    }
                    index = 0;
                }

                if (!String.IsNullOrWhiteSpace(boyTextBox.Text))
                {
                    while (!boyNameFound && index < boyNames.Length)
                    {
                        if (boyNames[index] == boyName)
                        {
                            boyNameFound = true;
                        }
                        index++;
                    }
                    index = 0;
                }

                if (!String.IsNullOrWhiteSpace(girlTextBox.Text))
                {
                    if (girlNameFound == true)
                    {
                        girlResultLabel.Text = "The name is among the most popular.";
                    }
                    else
                    {
                        girlResultLabel.Text = "The name is not among the most popular.";
                    }
                }
                else
                {
                    girlResultLabel.Text = "";
                }

                if (!String.IsNullOrWhiteSpace(boyTextBox.Text))
                {
                    if (boyNameFound == true)
                    {
                        boyResultLabel.Text = "The name is among the most popular.";
                    }
                    else
                    {
                        boyResultLabel.Text = "The name is not among the most popular.";
                    }
                }
                else
                {
                    boyResultLabel.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PAVEL GOLOVAN 2022\n\n" +
                "Enter a boy's name, a girl's name, or both, and the application will display " +
                "whether the names are among the most popular in Estonia.");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}