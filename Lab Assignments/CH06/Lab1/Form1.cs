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

        Random randomIndex = new Random(); 

        List<string> cookieSayings = new List<string> 
        {  
            "Birthdays are like friends. The more you have the better.",
            "Your smile is a treasure to all who know you.",
            "You never hesitate to tackle the most difficult problems.",
            "The most obvious solution is not always the best.",
            "If you want the rainbow, you will have to tolerate the rain.",
            "The early bird gets the worm, but the second mouse gets the cheese.",
            "From listening comes wisdom and from speaking repentance.",
            "A smile is your personal welcome mat." 
        };

        

        private void GenerateFortune()
        {
            int index1 = randomIndex.Next(cookieSayings.Count);
            int index2 = randomIndex.Next(cookieSayings.Count); 

            string randomString1 = cookieSayings[index1];
            string randomString2 = cookieSayings[index2];

            sayingLbl1.Text = randomString1;
            sayingLbl2.Text = randomString2;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateFortune();
        }
    }
}
