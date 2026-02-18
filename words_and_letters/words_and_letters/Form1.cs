using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace words_and_letters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnCountWords_Click(object sender, EventArgs e)
        {
            // get string info using method
            string user_text = txtString.Text;
            int total_words = countWords(user_text);
            // txtString.Text acts like a string but is an object
            double averageLength = (countCharacters(user_text) / (double);
            lblDisplay.Text = "Number of words " + total_words + "\n";
            lblDisplay.Text += "Average length: " + averageLength.ToString() + "\n";
        }

        private int countWords(string str)
        {
            int num_words = 0;
            Boolean word_begin = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 && !char.IsWhiteSpace(str[i]))
                {
                    word_begin = true;
                } else if (i > 0 && char.IsWhiteSpace(str[i - 1]) {
                    word_begin = true;

                } else
                {
                    word_begin = false;
                }

                if (word_begin && (char.IsLetterOrDigit(str[1]) || char.IsPunctuation(str[i]) {
                    // returns # words based on spaces

                }
            }
            return num_words;
        }

        private int countCharacters(string str)
        {
            string[] tokens = str.Split(null);
            int wordLength = 0;
            foreach (string s in tokens)
            {
                if (s.Length == 0)
                {
                    continue;
                } else
                {
                    wordLength = s.Length;               }
                }

                if (char.IsPunctuation(s[0])) {
                    wordLength--;
                }

                if (char.IsPunctuation(s(str.Length-1))) {
                    wordLength--;
                }
            return wordLength;
        }
        }
    }
}
