using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double length;
        double width;
       

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lengthInput.Text, out length) && double.TryParse(widthInput.Text, out width))
            {
                double area = length * width;
                areaLbl.Text = $"Area: {area} sq feet";

                double total = area * 20;
                totalCostLbl.Text = $"Total Cost: {total}";

                if (area >= 600)
                {
                    weeklyFeeLbl.Text = "Weekly Fee: $50";
                }
                else if (area >= 400 && area < 600)
                {
                    weeklyFeeLbl.Text = "Weekly Fee: $35";
                }
                else if (area < 400)
                {
                    weeklyFeeLbl.Text = "Weekly Fee: 25";
                }
            }   
        }
    }
}
