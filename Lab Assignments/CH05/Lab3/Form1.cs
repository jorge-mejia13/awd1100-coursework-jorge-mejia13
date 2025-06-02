using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int playerChoice;
        int playerScore;
        int computerScore;
        int computerChoice;

        private void gameCard()
        {
            // sets computer choice into string
            if (computerChoice == 1)
            {
                compChoiceLbl.Text = "Rock";
            }
            else if (computerChoice == 2)
            {
                compChoiceLbl.Text = "Paper";
            }
            else
            {
                compChoiceLbl.Text = "Scissors";
            }

            // gives player or computer point based on who wins
            if (playerChoice == 1 && computerChoice == 3 || playerChoice == 2 && computerChoice == 1 || playerChoice == 3 && computerChoice == 2)
            {
                playerScore++;
                playerScoreLbl.Text = playerScore.ToString();
            }
            else
            {
                computerScore++;
                computerScoreLbl.Text = computerScore.ToString();
            }

            // determines who wins 
            if (playerScore == 3)
            {
                resultLbl.Text = "Player wins!";
            }
            else if (computerScore == 3)
            {
                resultLbl.Text = "Computer wins!";
            }
        }

        private void rockBtn_Click(object sender, EventArgs e)
        {
            playerChoice = 1;

            // computer picks a random number
            Random randomNum = new Random();
            computerChoice = randomNum.Next(1, 4);

            gameCard();
        }

        private void paperBtn_Click(object sender, EventArgs e)
        {
            playerChoice = 2;

            // computer picks a random number
            Random randomNum = new Random();
            int computerChoice = randomNum.Next(1, 4);

            gameCard();
        }

        private void scissorsBtn_Click(object sender, EventArgs e)
        {
            playerChoice = 3;

            // computer picks a random number
            Random randomNum = new Random();
            int computerChoice = randomNum.Next(1, 4);

            gameCard();
        }
    }
}
