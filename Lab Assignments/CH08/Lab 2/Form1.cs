using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double numOfNights = 0;
            double costPerNight = 0;
            double totalCost = 0;

            double[] nightsStayed = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double[] nightlyRate = { 200, 200, 180, 180, 160, 160, 160, 145 };

            if (double.TryParse(nightsInput.Text, out numOfNights))
            {
                if (numOfNights >= 8)
                {
                    costPerNight = nightlyRate[7];
                }
                else
                {
                    for (int i = 0; i < nightsStayed.Length; i++)
                    {
                        if (numOfNights == nightsStayed[i])
                        {
                            costPerNight = nightlyRate[i];
                            break;
                        }
                    }
                }

                totalCost = numOfNights * costPerNight;
                nightResultLbl.Text = $"{costPerNight.ToString("C2")}"; 
                totalCostLbl.Text = $"{totalCost.ToString("C2")}";
            }
        }
    }
}
