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

        double danielleTotal;
        double francisTotal;
        double edwardTotal;
        double total;
        string topSales;

        private void danielleBtn_Click(object sender, EventArgs e)
        {
            double saleAmount = double.Parse(inputTxt.Text);

            danielleTotal += saleAmount;

            total += saleAmount;

            danielleLbl.Text = $"Danielles Sales: {danielleTotal.ToString()}";

            totalLbl.Text = $"Grand total: {total.ToString()}";

            MostSales();
        }

        private void francisBtn_Click(object sender, EventArgs e)
        {
            double saleAmount = double.Parse(inputTxt.Text);

            francisTotal += saleAmount;

            total += saleAmount;

            francisLbl.Text = $"Francis Sales: {francisTotal.ToString()}";

            totalLbl.Text = $"Grand total: {total.ToString()}";

            MostSales();
        }

        private void edwardBtn_Click(object sender, EventArgs e)
        {
            double saleAmount = double.Parse(inputTxt.Text);

            edwardTotal += saleAmount;

            total += saleAmount;

            edwardLbl.Text = $"Edward Sales: {edwardTotal.ToString()}";

            totalLbl.Text = $"Grand total: {total.ToString()}";

            MostSales();
        }

        private void MostSales()
        {

            if (edwardTotal > danielleTotal && edwardTotal > francisTotal)
            {
                mostSalesLbl.Text = $"Edward has the most sales";
            }
            else if (francisTotal > danielleTotal && francisTotal > edwardTotal)
            {
                mostSalesLbl.Text = "Francis has the most sales";
            } 
            else
            {
                mostSalesLbl.Text = "Danielle has the most sales";
            }

        }
    }
}
