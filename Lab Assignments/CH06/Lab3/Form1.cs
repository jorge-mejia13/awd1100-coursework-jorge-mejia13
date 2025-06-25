using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountVowels(string phrase)
        {
            int count = 0;

            string vowels = "aeiouAEIOU";

            for (int i = 0; i < phrase.Length; i++)
            {
                if (vowels.Contains(phrase[i]))
                {
                    count++;
                }
            }

            return count;
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            string userPhrase = inputTxt.Text;

            int numOfVowels = CountVowels(userPhrase);

            resultLbl.Text = $"There are {numOfVowels} vowels in your phrase";
        }
    }
}
