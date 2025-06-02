using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double CM_PER_IN = 2.54;

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox.Text, out double inches))
            {
                double centimeters = inches * CM_PER_IN;

                resultLbl.Text = $"{inches} inches is {centimeters} centimeters";
            }
            else
            {
                resultLbl.Text = "Enter a number";
            }
        }
    }
}
