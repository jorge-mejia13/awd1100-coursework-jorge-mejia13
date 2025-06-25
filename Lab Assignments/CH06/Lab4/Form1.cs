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
        public Form1()
        {
            InitializeComponent();
        }

        private int TotalArea(int length, int width)
        {
            int area = (length * 9 * 2) + (width * 9 * 2);
            return area;
        }

        private double CalculateEstimate(int area)
        {
            double price = 6 * area;
            return price;
        }


        private void calcBtn_Click(object sender, EventArgs e)
        {
            int width = int.Parse(widthInput.Text);
            int length = int.Parse(lengthInput.Text);

            int totalArea = TotalArea(length, width);
            totalAreaLbl.Text = $"Total Area: {totalArea}";

            double totalPrice = CalculateEstimate(totalArea);
            totalPriceLbl.Text = $"Total Price: {totalPrice:C}";

        }
    }
}
