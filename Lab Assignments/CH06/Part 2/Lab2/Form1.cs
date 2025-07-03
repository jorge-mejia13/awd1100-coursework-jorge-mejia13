using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SortWords(string[] unsortedWords)
        {

            Array.Sort(unsortedWords);
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            // get phrase string from input
            string phrase = sortInput.Text;
            // split phrase into words array
            string[] words = phrase.Split(' ');
            // sort array 
            SortWords(words);
            // join array into a string phrase again
            string sortedPhrase = string.Join(" ", words);

            resultLbl.Text = sortedPhrase;
        }
    }
}
