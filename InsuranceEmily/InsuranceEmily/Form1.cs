using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceEmily
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double cost, minInsurance;
                string output;
                double.TryParse(txtCost.Text, out cost);
                minInsurance = cost * .8;
                output = "Minimum amount of insurance to purchase: $" + minInsurance;
                lblMinInsurance.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
