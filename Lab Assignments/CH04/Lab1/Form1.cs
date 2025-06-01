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

        private void milesBtn_Click(object sender, EventArgs e)
        {
            const double KILOMETERS = 1.60934;

            double miles = double.Parse(milesTxt.Text);

            double answer = miles * KILOMETERS;

            answerLbl.Text = $"{miles} miles is {answer} km";
        }

        private void kmBtn_Click(object sender, EventArgs e)
        {

            const double MILES = 0.621371;

            double km = double.Parse(kmTxt.Text);

            double answer = km * MILES;

            answerLbl.Text = $"{km} kilometers is {answer} miles";
        }
    }
}
