using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Reverse4(ref int num1, ref int num2, ref int num3, ref int num4)
        {
            int temp1 = num1;
            int temp2 = num2;
            int temp3 = num3;
            int temp4 = num4;

            num1 = temp4;
            num2 = temp3;
            num3 = temp2;
            num4 = temp1;
        }

        private void reverseBtn_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(intInput1.Text);
            int num2 = int.Parse(intInput2.Text);
            int num3 = int.Parse(intInput3.Text);
            int num4 = int.Parse(intInput4.Text);

            Reverse4(ref num1, ref num2, ref num3, ref num4);

            resultLbl.Text = $"{num1.ToString()} {num2.ToString()} {num3.ToString()} {num4.ToString()}";
        }
    }
}
