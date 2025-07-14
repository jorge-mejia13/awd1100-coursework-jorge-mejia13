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

        Game[] games = new Game[5];
        public Form1()
        {
            InitializeComponent();

            games[0] = new Game("Player Unknown's Battlegrounds (PUBG)", "Bluehole", 35f);
            games[1] = new Game("League of Legends", "Riot Games", 0f);
            games[2] = new Game("Call of Duty: Black Ops II", "Activision", 60f);
            games[3] = new Game("Battlefield 4", "Electronic Arts (EA)", 20f);
            games[4] = new Game("Super Mario Odyssey", "Nintendo", 60f);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string game = gameSearchInput.Text.ToLower();
            int index = SearchForGame(game);
            ShowGameInfo(index);
        }

        public int SearchForGame(string game)
        {
            for (int i = 0; i < games.Length; i++)
            {
                if (games[i].GetName().ToLower().Contains(game) || games[i].GetPublisher().ToLower().Contains(game))
                {
                    return i;
                }
            }
            return -1;
        }

        public void ShowGameInfo(int index)
        {
            if (index != -1)
            {
                nameLbl.Text = $"Name: {games[index].GetName()}";
                publisherLbl.Text = $"Publisher: {games[index].GetPublisher()}";
                priceLbl.Text = $"Price: ${games[index].GetPrice()}";
            }
            else
            {
                nameLbl.Text = "Game not found";
                publisherLbl.Text = "Game not found";
                priceLbl.Text = "Game not found";
            }
        }
    }
}
 