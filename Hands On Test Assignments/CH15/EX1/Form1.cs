using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ShortTermLoan shortTermLoan = null;
        LongTermLoan longTermLoan = null;

        private void createLoanBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            double balance = double.Parse(amountInput.Text);

            if (shortTermBtn.Checked && balance > 0)
            {
                shortTermLoan = new ShortTermLoan(name, balance);

                nameLbl.Text = shortTermLoan.Name;
                balanceLbl.Text = $"{shortTermLoan.Type} of {shortTermLoan.Balance.ToString("C")}";
            }
            else if (longTermBtn.Checked && balance > 0)
            {
                longTermLoan = new LongTermLoan(name, balance);

                nameLbl.Text = longTermLoan.Name;
                balanceLbl.Text = $"{longTermLoan.Type} of {longTermLoan.Balance.ToString("C")}";
            }
            else
            {
                MessageBox.Show("You must choose the type of loan or amount greater than 0");
            }

            nameInput.Text = string.Empty;
            amountInput.Text = string.Empty;
        }

        private void makePaymentBtn_Click(object sender, EventArgs e)
        {
            if (shortTermLoan != null)
            {
                shortTermLoan.MakePayment();
                remainingBalanceLbl.Text = $"After the last loan payment the balance is down to ${shortTermLoan.Balance.ToString("C")}";

                shortTermLoan.ApplyInterest();
                remainingBalancePlusInterestLbl.Text = $"After the loan interest accumulation the loan is up to ${shortTermLoan.Balance.ToString("C")}";
            }
            else if (longTermLoan != null)
            {
                longTermLoan.MakePayment();
                remainingBalanceLbl.Text = $"After the last loan payment the balance is down to ${longTermLoan.Balance.ToString("C")}";

                longTermLoan.ApplyInterest();
                remainingBalancePlusInterestLbl.Text = $"After the loan interest accumulation the loan is up to ${longTermLoan.Balance.ToString("C")}";
            }

            if ((shortTermLoan != null && shortTermLoan.Balance <= 0) || (longTermLoan != null && longTermLoan.Balance <= 0))
            {
                remainingBalanceLbl.Text = "CONGRATS YOUR LOAN IS PAID OFF!!";
                remainingBalancePlusInterestLbl.Text = string.Empty;
            }
           
        }
    }
}
