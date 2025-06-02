using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercise_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showLetterBtn_Click(object sender, EventArgs e)
        {

            if (double.TryParse(gradeInputBox.Text, out double grade))
            {
                if (grade > 3.0)
                {
                    resultLbl.Text = "A";
                }
                else if (grade >= 2.0)
                {
                    resultLbl.Text = "B";
                }
                else if (grade >= 1.0)
                {
                    resultLbl.Text = "C";
                }
                else if (grade > 0)
                {
                    resultLbl.Text = "D";
                }
                else
                {
                    resultLbl.Text = "F";
                }
            } else
            {
                resultLbl.Text = "Please enter a number";
            }
        }
    }
}
