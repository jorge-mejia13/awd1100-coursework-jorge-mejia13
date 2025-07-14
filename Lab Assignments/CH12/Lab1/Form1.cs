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

        FlashCard[] cards = new FlashCard[20];
        public Form1()
        {
            InitializeComponent();
            cards[0] = new FlashCard("Loop", "A loop is a ");
            cards[1] = new FlashCard("Variable", "A var is a");
            cards[2] = new FlashCard("API", "A set of rules that allows different software applications to communicate with each other.");
            cards[3] = new FlashCard("Bug", "An error or flaw in a program that causes it to behave unexpectedly or incorrectly.");
            cards[4] = new FlashCard("Refactoring", "The process of improving the internal structure of code without changing its external behavior.");
        }
       
        private void defineBtn_Click(object sender, EventArgs e)
        {
            string term = termInput.Text;
            bool isFound = false;

            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null && cards[i].GetTerm().ToLower().Contains(term.ToLower()))
                {
                    definitionLbl.Text = cards[i].GetDefinition();
                    isFound = true;
                    return;
                }
            }

            if (!isFound)
            {
                definitionLbl.Text = "I don't have that term yet. Want to add it?";
            } 

        }

        private void addTermBtn_Click(object sender, EventArgs e)
        {
            string definition = definitionInput.Text;
            string term = termInput.Text;

            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == null)
                {
                    cards[i] = new FlashCard(term, definition);
                    definitionInput.Text = string.Empty;
                    termInput.Text = string.Empty;
                    definitionLbl.Text = "New definition added";
                    return;
                }
                
            }
        }
    }
}
