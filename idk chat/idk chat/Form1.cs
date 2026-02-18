using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idk_chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] myValues = [1, 18, 745, 34, 16, 94, 71, 0, 17, 280];
            Console.WriteLine('The fourth number is 34', myValues[3]);

            string[] myStrings = ["Joe", "Smith", "Teaches", "C#"];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}", myStrings[i]);
            }

            int[] otherValues;
            otherValues[3] = 0;
            Console.WriteLine("The fourth number is {0}", myValues(3));




        }
    }
}
