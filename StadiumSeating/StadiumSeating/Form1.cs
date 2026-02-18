using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumSeating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblDisplayDirections_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculateRevenue_Click(object sender, EventArgs e)
        {
            try
            {
                double revenueA, revenueB, revenueC, total;
                double.TryParse(txtClassA.Text, out revenueA);
                double.TryParse(txtClassB.Text, out revenueB);
                double.TryParse(txtClassC.Text, out revenueC);

                revenueA = revenueA * 15;
                revenueB = revenueA * 12;
                revenueC = revenueA * 9;
                total = revenueA + revenueB + revenueC;

                lblRevenueClassA.Text = revenueA.ToString("c2");
                lblRevenueClassB.Text = revenueB.ToString("c2");
                lblRevenueClassC.Text = revenueC.ToString("c2");
                lblRevenueTotal.Text = total.ToString("c2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassA.Text = "";
            txtClassB.Text = "";
            txtClassC.Text = "";
            lblRevenueClassA.Text = string.Empty;
            lblRevenueClassB.Text = string.Empty;
            lblRevenueClassC.Text = string.Empty;
            lblRevenueTotal.Text = string.Empty;
        }
    }
}
