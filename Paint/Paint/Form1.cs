using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
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
                double square_feet;
                double price_of_paint;
                double priceOfPaintRequired;
                double laborRequired;
                double cost_of_paint;
                double labor_charges;
                double total;
                string output;

                double.TryParse(txtSquareFeet.Text, out square_feet);
                double.TryParse(txtPrice.Text, out price_of_paint);

                priceOfPaintRequired = Math.Round((square_feet / 115), 2);
                laborRequired = Math.Round((square_feet / 115 * 8), 2);
                cost_of_paint = (square_feet / 115) * price_of_paint;
                labor_charges = ((square_feet / 115) * 8 * 20);
                total = (square_feet / 115) * (160 + price_of_paint);

                output = "The number of gallons of paint required: " + priceOfPaintRequired + "\nThe cost of labor required: " + laborRequired.ToString() + "\nThe labor charges: " + labor_charges.ToString() + "\nThe total cost of the paint: " + total.ToString("c2");

                lblOutput.Text = output;
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
