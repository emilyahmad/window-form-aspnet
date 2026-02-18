using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgram2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            // step 1 declare variables
            decimal markupPrice;
            string item;
            decimal price;
            decimal total;

            // get input & convert: triparse method
            // parse only converts 1 time
            decimal.TryParse(txtPrice.Text, out price);
            item = txtItem.Text;


            // algorithm
            total = price * 1.25m;

            // output
            lblMarkupPrice.Text = "The item is " + item + " and the new price is " + total.ToString("C2");


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
