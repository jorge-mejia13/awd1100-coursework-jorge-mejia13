using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsStudentAccepted(float gpa, int testScore)
        {
            if (gpa >= 3.0 && testScore >= 60)
            {
                return true;
            }

            if (gpa < 3.0 &&  testScore >= 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void adminBtn_Click(object sender, EventArgs e)
        {
            float gpaScore = float.Parse(gpaInput.Text);
            int testScore = int.Parse(testScoreInput.Text);

            if (IsStudentAccepted(gpaScore, testScore))
            {
                resultLbl.Text = "Accepted";
            }
            else
            {
                resultLbl.Text = "Reject";
            }

        }
    }
}
