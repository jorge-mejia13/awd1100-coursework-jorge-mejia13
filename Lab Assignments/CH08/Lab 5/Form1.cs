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

        private void maskBtn_Click(object sender, EventArgs e)
        {
            string number = numberInput.Text;

            resultLbl.Text = string.Empty;

            // total number of digits
            int totalDigits = 0;

            // gathers total number of only digits
            for (int i  = 0; i < number.Length; i++)
            {
                if (char.IsDigit(number[i]))
                {
                    totalDigits++;
                }
            }

            // number of digits to mask
            int maskedDigits = totalDigits - 4;

            int digitCount = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsDigit(number[i]))
                {
                    if (digitCount < maskedDigits)
                    {
                        resultLbl.Text += '#';
                    }
                    else
                    {
                        resultLbl.Text += number[i];
                    }

                    digitCount++;
                }
                else
                {
                    resultLbl.Text += number[i];
                }
            }


            numberInput.Text = string.Empty;
        }
    }
}
