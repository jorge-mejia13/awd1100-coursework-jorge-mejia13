using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double zipCode;
           
            double[] codes = { 63101, 63103, 63105, 63109, 63113, 63118, 63130, 63133, 63136, 63137 };

            double[] price = { 20, 12, 25, 15, 10, 23, 18, 20, 17, 12 };

            bool isFound = false;

            // checks if zip code can be converted and converts into double
            if (double.TryParse(zipcodeInput.Text, out zipCode))
            {
                // loops through all the codes
                for (int i = 0; i < codes.Length; i++)
                {
                    // finds is theres a match 
                    if (zipCode == codes[i])
                    {
                        resultLbl.Text = $"${price[i].ToString()}";
                        isFound = true;
                        break;
                    }
                }
                // if no zip code is found show message in the label
                if (isFound == false)
                {
                    resultLbl.Text = "No zip code was found";
                }
            }
        }
    }
}
