using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 5;
                int b = 0;
                int answer = a / b;
                MessageBox.Show(answer.ToString());
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = "jorge";
                int nameAsNumber = int.Parse(name);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            try
            {
                object strings = "hello world";
                int invalidCast = (int)strings;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                string name = null;
                int nameLength = name.Length;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
