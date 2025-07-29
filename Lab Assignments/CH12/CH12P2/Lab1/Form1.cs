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
        Order anOrder;
        double grandTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addItemToOrderBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;

            if ((chkSundae.Checked || chkSoda.Checked) && !String.IsNullOrEmpty(name))
            {
                bool isValid = true;

                // create order
                nameOrFoodErrorLbl.Visible = false;

                anOrder = new Order(name, chkSundae.Checked, chkSoda.Checked);

                if (chkSundae.Checked)
                {
                    if (chkSprinkles.Checked && chkNuts.Checked && chkSyrup.Checked)
                    {
                        // error message
                        toppingsErrorLbl.Visible = true;
                        isValid = false;
                    }
                    else
                    {
                        // add toppings
                        toppingsErrorLbl.Visible = false;    
                        if (chkSprinkles.Checked) anOrder.Sundae.AddTopping(SundaeTopping.SPRINKLES); 
                        if (chkNuts.Checked) anOrder.Sundae.AddTopping(SundaeTopping.NUTS);
                        if (chkSyrup.Checked) anOrder.Sundae.AddTopping(SundaeTopping.CHOCOLATE_SYRUP);

                    }
                }

                if (chkSoda.Checked)
                {
                    if (chkLime.Checked && chkPeach.Checked || chkLime.Checked && chkMango.Checked || chkMango.Checked && chkPeach.Checked)
                    {
                        sodaFlavorErrorLbl.Visible = true;
                        isValid = false;
                    }
                    else
                    {
                        sodaFlavorErrorLbl.Visible = false;
                        if (chkLime.Checked) anOrder.Soda.AddFlavor(SodaFlavor.LIME);
                        if (chkMango.Checked) anOrder.Soda.AddFlavor(SodaFlavor.MANGO);
                        if (chkPeach.Checked) anOrder.Soda.AddFlavor(SodaFlavor.PEACH);    
                    }
                }   

                if (isValid)
                {
                    // outputs total
                    grandTotal += anOrder.Price;
                    totalLbl.Text = grandTotal.ToString("C");

                    // outputs name
                    outputBox.Text += anOrder.Name;
                    outputBox.Text += "\n--------------\n";

                    if (anOrder.Soda == null)
                    {
                        // output sundae
                        DisplaySundae();
                        outputBox.Text += "\n";
                    }
                    else if (anOrder.Sundae == null)
                    {
                        // output soda
                        DisplaySoda();
                        outputBox.Text += "\n";
                    }
                    else
                    {
                        // output both
                        DisplaySundae();
                        DisplaySoda();
                        outputBox.Text += "\n";
                    }

                }
            }
            else
            {
                // error message
                nameOrFoodErrorLbl.Visible = true;
            }
            
        }

        private void DisplaySundae()
        {
            outputBox.Text += "Sundae - ";

            int toppingCount = anOrder.Sundae.ToppingCount;

            if (toppingCount == 0)
            {
                outputBox.Text += anOrder.Sundae.GetTopping(0) + " - ";
            }
            else
            {
                for (int i = 0; i < toppingCount; i++)
                {
                    outputBox.Text += anOrder.Sundae.GetTopping(0) + " - ";
                }
            }
            outputBox.Text += anOrder.Sundae.Price.ToString("C") + "\n";
        }

        private void DisplaySoda()
        {
            outputBox.Text += "Soda - ";

            outputBox.Text += anOrder.Soda.Flavor + " - ";

            outputBox.Text += anOrder.Soda.Price.ToString("C") + "\n";
        }

        private void chkSundae_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSundae.Checked)
            {
                sundaeToppingsGrp.Visible = true;
            }
            else
            {
                sundaeToppingsGrp.Visible = false;
            }
        }

        private void chkSoda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSoda.Checked)
            {
                sodaFlavorsGrp.Visible = true;
            }
            else
            {
                sodaFlavorsGrp.Visible = false;
            }
        }
    }
}
