using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> movies = new List<string> { "Heat", "Drive", "Taken", "Dredd", "John Wick" };
        List<string> directors = new List<string>
        {
            "Michael Mann",
            "Nicolas Winding Refn",
            "Pierre Morel",
            "Chad Stahelski",
            "Pete Travis"
        };

        List<string> descriptions = new List<string>
        {
            "A master thief and a relentless detective face off in Los Angeles.",
            "A stunt driver moonlights as a getaway driver in a violent underworld.",
            "A retired agent hunts down his daughter’s kidnappers in Europe.",
            "A retired hitman seeks revenge for the death of his dog.",
            "A futuristic law enforcer dispenses brutal justice in a dystopian city."
        };

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string movieSearched = movieSearchInput.Text;

            bool found = false;

            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].ToLower().Contains(movieSearched.ToLower()) || directors[i].ToLower().Contains(movieSearched.ToLower()))
                {
                    nameLbl.Text = $"Name: {movies[i]}";
                    directorLbl.Text = $"Director: {directors[i]}";    
                    descLbl.Text = $"Description: {descriptions[i]}"; 
                    movieSearchInput.Text = string.Empty;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                nameLbl.Text = "Movie not found";
                directorLbl.Text = "Movie not found";
                descLbl.Text = "Movie not found";
            }
        }
    }
}
