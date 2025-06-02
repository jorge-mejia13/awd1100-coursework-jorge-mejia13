using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string category;

            int windSpeed = int.Parse(windTxtInput.Text);

            if (windSpeed >= 157)
            {
                category = "Category 5";
            } else if (windSpeed >= 130) 
            {
                category = "Category 4";
            } else if (windSpeed >= 111)
            {
                category = "Category 3";
            } else if (windSpeed >= 96)
            {
                category = "Category 2";
            } else if (windSpeed >= 74)
            {
                category = "Category 1";
            } else
            {
                category = "Not a hurricane";
            }

            categoryTxtInput.Text = category;
        }
    }
}
