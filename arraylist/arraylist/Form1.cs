using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace arraylist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList myAl = new ArrayList();
            myAl.Add("one");
            myAl.Add("one");
            myAl.Add(2);
            myAl.Add("Three");
            myAl.Add(4);
            myAl.Add(5);
            myAl.Insert(0, 1.25);

            foreach (o in myAl)
            {
                if (o is int)
                {
                    Console.WriteLine("{0}", o);
                }

                if (o is float)
            }
        }
    }
}
