using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        List<string> games = new List<string> { "Player Unknown's Battlegrounds (PUBG)", "League of Legends", "Call of Duty: Black Ops III", "Battlefield 4", "Super Mario Odyssey" };
        List<string> publishers = new List<string> { "Bluehole", "Riot Games", "Activision", "Electronic Arts (EA)", "Nintendo" };
        List<double> prices = new List<double> { 35, 0, 60, 20, 60 };

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string gameSearched = searchInput.Text.ToLower();

            bool found = false;

            for (int i = 0; i < games.Count && found == false; i++)
            {
                if (games[i].ToLower().Contains(gameSearched) || publishers[i].ToLower().Contains(gameSearched))
                {
                    nameLbl.Text = games[i];
                    publisherLbl.Text = publishers[i];
                    priceLbl.Text = prices[i].ToString();
                    found = true;
                }
            }
            if (!found)
            {
                nameLbl.Text = "Game Not Found";
                publisherLbl.Text = "Game Not Found";
                priceLbl.Text = "Game Not Found";
            }
        }
    }
}
