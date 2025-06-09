using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string phrase = inputTxt.Text;

            int vowelCount = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                string letter = phrase.Substring(i, 1).ToLower();

                switch (letter)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        vowelCount++;
                        break;
                }

                answerLbl.Text = $"There are {vowelCount} vowels in your phrase";
            }
        }
    }
}
