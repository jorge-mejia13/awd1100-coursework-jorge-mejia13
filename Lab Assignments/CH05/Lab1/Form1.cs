﻿using System;
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

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            double gpaTxt = double.Parse(gpaInput.Text);
            double admissionsTxt = double.Parse(adminInput.Text);

            if (gpaTxt >= 3.0 && admissionsTxt >= 60) 
            {
                answerLbl.Text = "Accept";
            } else if (gpaTxt <= 3.0 && admissionsTxt >= 80)
            {
                answerLbl.Text = "Accept";
            } else
            {
                answerLbl.Text = "Reject";
            }

        }
    }
}
