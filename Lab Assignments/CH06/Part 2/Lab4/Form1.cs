using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numbersList = new List<int>();

        public void CalculateStats(out int min, out int max, out double sum, out double avg, params int[] numbers)
        {
            min = numbers[0];
            max = numbers[0];
            sum = 0;
            avg = 0.0;
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                count++;

                if (numbers[i] > max)
                {
                    max = numbers[i];       
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];                  
                }
            }

            avg = sum / count;

            sumLbl.Text = $"{sum}";
            maxLbl.Text = $"{max}";
            minLbl.Text = $"{min}";
            avgLbl.Text = $"{avg}";
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            int number = int.Parse(statsInput.Text);

            numbersList.Add(number);

            int[] numbersArray = numbersList.ToArray();

            CalculateStats(out int min, out int max, out double sum, out double avg, numbersArray);
        }
    }
}
