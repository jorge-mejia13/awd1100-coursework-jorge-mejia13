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

        private void calcBtn_Click(object sender, EventArgs e)
        {
            int chicken1 = int.Parse(chicken1Txt.Text);
            int chicken2 = int.Parse(chicken2Txt.Text);
            int chicken3 = int.Parse(chicken3Txt.Text);
            int chicken4 = int.Parse(chicken4Txt.Text);

            int totalEggs = chicken1 + chicken2 + chicken3 + chicken4;

            int dozenEggs = totalEggs / 12;

            int leftoverEggs = totalEggs % 12;

            displayLbl.Text = $"{totalEggs} eggs total, or {dozenEggs} dozens and {leftoverEggs} eggs.";
        }
    }
}
