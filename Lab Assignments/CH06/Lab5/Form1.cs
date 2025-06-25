using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string MaskNumber(string unmaskedCC, char replacementChar, int numDigitsToPreserve)
        {
            

            // total number of digits
            int totalDigits = 0;

            // gathers total number of only digits
            for (int i = 0; i < unmaskedCC.Length; i++)
            {
                if (char.IsDigit(unmaskedCC[i]))
                {
                    totalDigits++;
                }
            }

            // number of digits to mask
            int maskedDigits = totalDigits - numDigitsToPreserve;

            int digitCount = 0;

            string maskedResult = "";

            for (int i = 0; i < unmaskedCC.Length; i++)
            {
                if (char.IsDigit(unmaskedCC[i]))
                {
                    if (digitCount < maskedDigits)
                    {
                        maskedResult += replacementChar;
                    }
                    else
                    {
                        maskedResult += unmaskedCC[i];
                    }

                    digitCount++;
                }
                else
                {
                    maskedResult += unmaskedCC[i];
                }
            }

            return maskedResult;
        }


        private void maskBtn_Click(object sender, EventArgs e)
        {
            string inputNumber = numberInput.Text;
            string inputNumberMasked = MaskNumber(inputNumber, '#', 4);
            resultLbl.Text = inputNumberMasked;

        }
    }
}
