using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                short itemNumber = short.Parse(itemNumberInput.Text);
                byte quantity = byte.Parse(quantityInput.Text);
                byte estimatedDays = byte.Parse(estDeliveryDaysInput.Text);

                Order order = new Order(itemNumber, quantity, estimatedDays);

                resultLbl.Text = "Order is valid";
            }
            catch (InvalidItemNumberException ex)
            {
                resultLbl.Text = ex.Message;
            }
            catch (InvalidQuantityException ex)
            {
                resultLbl.Text = ex.Message;
            }
            catch (InvalidDeliveryDaysException ex)
            {
                resultLbl.Text = ex.Message;
            }
        }
    }
}
