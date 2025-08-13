using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
           try
           {
               float weight = float.Parse(weightInput.Text);
               float height = float.Parse(heightInput.Text);

               Bmi newBmi = BmiCalculator.CalcBmi(weight, height);

               bmiLbl.Text = $"BMI: {newBmi.BMI}";
               categoryLbl.Text = $"Category: {newBmi.WeightCategory}";

               errorLbl.Text = string.Empty;
           }
           catch (InvalidWeightException ex)
           {
               errorLbl.Text = ex.Message;
           }
           catch (InvalidHeightException ex)
           {
               errorLbl.Text = ex.Message;
           }
        }
    }
}
