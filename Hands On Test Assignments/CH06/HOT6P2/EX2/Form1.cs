using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float shirtPrice = 13.75f;
        float taxRate = 0.08f;

        float[] discountCodes = { 8264, 5679, 6483 };

        private float CheckDiscountCode(string code)
        {
           if (float.TryParse(code, out float discountCode))
           {
                for (int i = 0; i < discountCodes.Length; i++)
                {
                    if (discountCode == discountCodes[i])
                    {
                        if (discountCode == 8264)
                        {
                            return 0.30f;
                        }
                        if (discountCode == 5679)
                        {
                            return 0.20f;
                        } 
                        if (discountCode == 6483)
                        {
                            return 0.10f;
                        }
                    }
                }

                return 0.0f;
           }
           else
           {
               return 0.0f;
           }
        }

        private void ShowInvoice(int quantity, float discountPercentage)
        {
            float subtotal;
            float tax;
            float total;
            

            if (discountPercentage == 0.0f)
            {
                shirtCounterLbl.Text = $"{quantity} T-Shirts @ $13.75 each";

                subtotal = quantity * shirtPrice;
                subtotalLbl.Text = $"Subtotal: ${subtotal}";

                tax = taxRate * subtotal;
                taxLbl.Text = $"Tax: ${tax}";

                total = tax + subtotal;
                totalLbl.Text = $"Total: ${total}";

                codeAcceptLbl.Text = "Invalid Discount Code";
            }
            else
            {
                float discount = discountPercentage * 100;
                codeAcceptLbl.Text = $"{discount}% Discount Applied!";


                float newShirtPrice = shirtPrice - (shirtPrice * discountPercentage);

                shirtCounterLbl.Text = $"{quantity} T-Shirts @ ${newShirtPrice} each";

                subtotal = quantity * newShirtPrice;
                subtotalLbl.Text = $"Subtotal: ${subtotal}";

                tax = taxRate * subtotal;
                taxLbl.Text = $"Tax: ${tax}";

                total = tax + subtotal;
                totalLbl.Text = $"Total: ${total}";
            }
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(qtInput.Text);
            string discountCode = dcInput.Text;

            float userCode = CheckDiscountCode(discountCode);

            ShowInvoice(quantity, userCode);
        }
    }
}
