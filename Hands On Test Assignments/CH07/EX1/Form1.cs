using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        TestStatistics testScores = new TestStatistics();
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                float score = float.Parse(scoreInput.Text);

                testScores.AddScore(score);

                resultLbl.Text = String.Empty;

                resultLbl.Text += $"Number of scores {testScores.Count}\n" + $"Sum of the test scores{testScores.Sum}\n" + $"Average test score{testScores.Average}" + $"Lowest test score {testScores.Min}" + $"Highest test score {testScores.Max}";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
