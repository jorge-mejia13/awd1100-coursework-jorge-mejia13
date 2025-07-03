using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string ParseBid(string bidString)
        {
            if (int.TryParse(bidString, out int bid))
            {
                if (bid >= 10)
                {
                    return $"Bid of {bid} was accepted";
                }
                else
                {
                    return "Bid must be $10 or more";
                }
            }

            if (decimal.TryParse(bidString, out decimal decimalBid))
            {
                if (decimalBid >= 10)
                {
                    return $"Bid of {bidString} was accepted";
                }
                else
                {
                    return "Bid must be $10 or more";
                }
            }

            if (bidString.Contains("$") || bidString.Contains("dollars"))
            {
                string numberPart = bidString.Replace("dollars", "").Replace("$", "").Trim();

                if (int.TryParse(numberPart, out int intNum))
                {
                    if (intNum >= 10)
                    {
                        return $"Bid of {bidString} was accepted";
                    }
                    else
                    {
                        return "Bid must be $10 or more";
                    }
                }
                else if (decimal.TryParse(numberPart, out decimal decNum))
                {
                    if (decNum >= 10)
                    {
                        return $"Bid of {bidString} was accepted";
                    }
                    else
                    {
                        return "Bid must be $10 or more";
                    }
                }
                else
                {
                    return "Bid is invalid";
                }
            }

            else
            {
                return "Invalid Bid";
            }
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            string bidAmount = bidInput.Text;

            string bid = ParseBid(bidAmount);

            resultLbl.Text = bid;
        }
    }
}
