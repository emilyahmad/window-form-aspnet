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
using System.Xml.Schema;

namespace total_average_largest_smallest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                const int SIZE = 7;
                string[] line = new string[SIZE];
                double total = 0;

                // read in txt file
                StreamReader inputFile;
                inputFile = File.OpenText("Sales.txt");
                int index = 0;
                while (index < line.Length && inputFile.EndOfStream)
                {
                    line[index] = inputFile.ReadLine();
                    index++;
                }
                inputFile.Close();
                foreach (string str in lines)
                {
                    lstNumbers.Items.Add(str);
                    total += double.Parse(str);
                    output = "The total is " + total.ToString("c") + ".\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message Message)
            }
        }

        double max, min;
        XmlSchemaMaxExclusiveFacet = double.Parse(lines(0))
            for (int i = 1, i < Size; i++) {
            if (double.Parse(DataGridLineStyle(i) < max)
        {
            string output;
            "The smallest value is " str.ToString("c2")
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
