using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        Job[] jobs = new Job[20];
        public Form1()
        {
            InitializeComponent();
            jobs[0] = new Job("Wash windows", 5, 50);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string description = descriptionInput.Text;
            float hoursToComplete = float.Parse(hoursToCompleteInput.Text);
            float hourlyRate = float.Parse(hourlyRateInput.Text);
            int index = -1;

            for (int i = 0; i < jobs.Length; i++)
            {
                if (jobs[i] != null && jobs[i].Description.ToLower().Contains(description.ToLower()))
                {
                    jobs[i].HoursToComplete = hoursToComplete;
                    jobs[i].HourlyFee = hourlyRate;
                    index = i;
                    break;
                }

                if (jobs[i] == null)
                {
                    jobs[i] = new Job(description, hoursToComplete, hourlyRate);
                    index = i;
                    break;
                }
            }

            descriptionLbl.Text = jobs[index].Description;
            hoursToCompleteLbl.Text = $"{jobs[index].HoursToComplete}";
            hourlyRateLbl.Text = $"${jobs[index].HourlyFee}";
            totalFeeLbl.Text = $"${jobs[index].TotalFee}";

        }
    }
}
