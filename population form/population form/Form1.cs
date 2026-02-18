using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace population_form {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        int year, currPop, nextPop, currDifference;
        int avgChange = 0;
        int greatestIncrease = 0;
        int leastIncrease = 0;

        private void lblSummary_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readPopulation();
        }

        private void readPopulation()
        {
            try {
                StreamReader inputFile;
                inputFile = File.OpenText("USPopulation.txt");

                int year = 0;
                while (!inputFile.EndOfStream) {

                    if (year == 0) {
                        currPop = int.Parse(inputFile.ReadLine());
                    } else {
                        currPop = nextPop;
                    } // read in next year's data & find difference

                    avgChange += currPop;
                    nextPop = int.Parse(inputFile.ReadLine());
                    currDifference = nextPop - currPop;
                    
                    if (currDifference > greatestIncrease)
                    {
                        greatestIncrease = currDifference;
                    }
                    else if (currDifference < leastIncrease)
                    {
                        leastIncrease = currDifference;
                    }

                    lblSummary.Text += (1951 + year).ToString() + "\t" + currDifference;
                    year++;
                }

                avgChange /= year;
                lblSummary.Text = "The average annual change in population is: " + avgChange +
                "\nThe year with the greatest increase is " + greatestIncrease
                + "\nThe year with the lesat increase is " + leastIncrease;

            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
