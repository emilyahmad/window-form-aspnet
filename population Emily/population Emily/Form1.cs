using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace population_Emily
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string output;
        int year, currPop, nextPop;
        int currDifference = 0;
        int avgChange = 0;
        int greatestIncrease = 0;
        int gYear = 0;
        int leastIncrease = 0;
        int lYear = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("USPopulation.txt");

                int year = 0;
                while (!inputFile.EndOfStream)
                {

                    if (year == 0) // data from 1951
                    {
                        currPop = int.Parse(inputFile.ReadLine());
                    } else {
                        currPop = nextPop;
                    }

                    avgChange += currPop;
                    nextPop = int.Parse(inputFile.ReadLine());
                    currDifference = nextPop - currPop;

                    output = (1951 + year).ToString() + "\t" + currDifference;
                    lstData.Items.Add(output);
                    year++;

                    if (currDifference > greatestIncrease)
                    {
                        greatestIncrease = currDifference;
                        gYear = 1951 + year;
                    }
                    else if (currDifference < leastIncrease)
                    {
                        leastIncrease = currDifference;
                        lYear = 1951 + year;
                    }

                    lstData.Text = (1951 + year).ToString() + "\t" + currDifference;
                    year++;
                }

                
                avgChange = avgChange/year;

                lblSummary.Text = "The average annual change in population is: " + avgChange +
                "\nThe year with the greatest increase is " + greatestIncrease
                + "\nThe year with the least increase is " + leastIncrease;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
