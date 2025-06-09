using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //double score;
        int sumOfScores;
        int numOfTestScores;
        int lowestScore = int.MaxValue;
        int highestScore = int.MinValue;
        int averageScore;


        private void scoreBtn_Click(object sender, EventArgs e)
        {
            string input = scoreInput.Text;
            int score = int.Parse(input);
            scoreInput.Text = string.Empty;

            if (score == 999)
            {
                averageScore = numOfTestScores / sumOfScores;
                numOfScoresLbl.Text = $"Number of scores: {numOfTestScores}";
                sumOfScoresLbl.Text = $"Sum of scores: {sumOfScores}";
                averageScoreLbl.Text = $"Average of scores: {averageScore}";
                lowerScoreLbl.Text = $"Lowest test scores: {lowestScore}";
                highestScoreLbl.Text = $"Highest test scores: {highestScore}";
            }
            else if (score >= 0 && score <= 100)
            {
                // add every score together
                sumOfScores += score;
                // increment the number of scores by 1
                numOfTestScores++;

                if (score < lowestScore)
                {
                    lowestScore = score;
                }

                if (score > highestScore)
                {
                    highestScore = score;
                }
            }
            else
            {
                MessageBox.Show("Score must meet requirements");
            }

        }
    }
}


