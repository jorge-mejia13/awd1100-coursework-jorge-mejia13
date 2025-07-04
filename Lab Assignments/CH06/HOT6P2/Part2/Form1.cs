using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int smCounter = 0;
        int mdCounter = 0;
        int lgCounter = 0;

        decimal smPrice = 9.99m;
        decimal mdPrice = 10.99m;
        decimal lgPrice = 11.99m;

        decimal taxRate = 0.07m;

        private void AddShirt(string size)
        {
            if (size.ToLower() == "s")
            {
                smCounter++;
                smCounterLbl.Text = smCounter.ToString();
            }
            else if (size.ToLower() == "m")
            {
                mdCounter++;
                mdCounterLbl.Text = mdCounter.ToString();
            }
            else if (size.ToLower() == "l")
            {
                lgCounter++;
                lgCounterLbl.Text = lgCounter.ToString();
            }

            ShowInvoice();
        }

        private void ShowInvoice()
        {
            smLbl.Text = $"{smCounter} Small @ $9.99 each";
            mdLbl.Text = $"{mdCounter} Medium @ $10.99 each";
            lgLbl.Text = $"{lgCounter} Large @ $11.99 each";

            decimal subtotal = (smCounter * smPrice) + (mdCounter * mdPrice) + (lgCounter * lgPrice);
            subtotalLbl.Text = $"Subtotal: ${subtotal.ToString("0.00")}";

            decimal tax = taxRate * subtotal;
            taxLbl.Text = $"Tax: ${tax.ToString("0.00")}";

            decimal total = subtotal + tax;
            totalLbl.Text = $"Total: {total.ToString("0.00")}";
        }

        private void ClearOrder()
        {
            smCounter = 0;
            mdCounter = 0;
            lgCounter = 0;

            smCounterLbl.Text = string.Empty;
            mdCounterLbl.Text = string.Empty;
            lgCounterLbl.Text = string.Empty;

            smLbl.Text = string.Empty;
            mdLbl.Text = string.Empty;
            lgLbl.Text = string.Empty;

            subtotalLbl.Text = string .Empty;
            taxLbl.Text = string.Empty;
            totalLbl.Text = string.Empty;  
        }

        private void smBtn_Click(object sender, EventArgs e)
        {
            string size = smBtn.Text;
            AddShirt(size);
        }

        private void mdBtn_Click(object sender, EventArgs e)
        {
            string size = mdBtn.Text;
            AddShirt(size);
        }

        private void lgBtn_Click(object sender, EventArgs e)
        {
            string size = lgBtn.Text;
            AddShirt(size);
        }

        private void clearOrderBtn_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }
    }
}
