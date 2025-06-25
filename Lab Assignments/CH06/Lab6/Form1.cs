using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetWood()
        {
            string woodChoice = woodInput.Text.Trim().ToLower();

            if (woodChoice == "o")
            {
                return "oak";
            }
            else if (woodChoice == "p")
            {
                return "pine";
            }
            else if (woodChoice == "m")
            {
                return "mohogany";
            }
            else
            {
                return "other";
            }
        }
        private int GetDrawers()
        {
            int drawers = 0;

            if (int.TryParse(drawersInput.Text, out drawers) && drawers >= 0)
            {
                return drawers;
            }
            return drawers;
        }
        // gets the cost of the wood
        private double CalculateWoodCost(string woodType)
        {
            if (woodType == "oak")
            {
                return 140;
            }
            else if (woodType == "pine")
            {
                return 100;
            }
            else
            {
                return 180;
            }
            
        }
        private double CalculateDrawerCost(int numDrawers)
        {
            return 30 * numDrawers;

        }
        private double CalculateTotalCost(string woodType, int numDrawers)
        {
           return CalculateWoodCost(woodType) + CalculateDrawerCost(numDrawers);
        }


        private void estimateBtn_Click(object sender, EventArgs e)
        {
            string woodChoice = GetWood();
            int drawerChoice = GetDrawers();
            double woodCost = CalculateWoodCost(woodChoice);
            double drawerCost = CalculateDrawerCost(drawerChoice);

            double totalCost = CalculateTotalCost(woodChoice, drawerChoice);


            woodLbl.Text = $"Wood Cost: ${woodCost.ToString()}";
            drawerLbl.Text = $"Drawer Cost: ${drawerCost.ToString()}";
            totalLbl.Text = $"Total Cost Cost: ${totalCost.ToString()}";
        }
    }
}


