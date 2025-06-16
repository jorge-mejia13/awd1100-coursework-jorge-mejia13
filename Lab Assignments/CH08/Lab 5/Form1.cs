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

            int visibleDigits = 4;
            char poundSign = '#';

            if (number.Length > visibleDigits)
            {
                string maskedPart = new string(poundSign, number.Length - visibleDigits);
                string lastDigits = number.Substring(number.Length - visibleDigits);
                string result = maskedPart + lastDigits;

                resultLbl.Text = result;
            }
        }
    }
}
