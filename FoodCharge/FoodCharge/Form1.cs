using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCharge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double food_charge = double.Parse(txtPrice.Text);
            double sales_tax = food_charge * .07;
            double tip = food_charge * .2;
            double total = food_charge + sales_tax + tip;

            lblBill.Text = "Food charge:..." + food_charge.ToString("c2") +
                "\n" + "Total:..." + "7% Sales Tax:..." + sales_tax.ToString("c2") + "\n" + "20% Tip:..." + tip.ToString("c2") + "\n" +
                "Total Charge:..." + total.ToString("c2");
        }
    }
}
