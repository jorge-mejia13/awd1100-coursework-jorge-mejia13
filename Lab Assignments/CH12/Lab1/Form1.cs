using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void defineBtn_Click(object sender, EventArgs e)
        {
            string term = termInput.Text;

            FlashCard[] cards = new FlashCard[20];

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = new FlashCard();
            }

            cards[0].Definition = "A loop is...";
            definitionLbl.Text = cards[0].Definition;
        }
    }
}
