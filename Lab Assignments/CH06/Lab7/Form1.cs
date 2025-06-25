using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> accountNumbers = new List<string> { "1111", "2222", "3333", "4444" };
        List<string> pinNumbers = new List<string> { "1234", "2345", "3456", "4567" };
        List<string> names = new List<string> { "M Smith", "J Mejia", "D Hooker", "J Jones" };
        List<decimal> balances = new List<decimal> { 1000.00m, 500.00m, 750.00m, 600.00m };

        int currentUser = -1;

        private void Login(string accountNum, string pin)
        {
            bool userFound = false;

            for (int i = 0; i < accountNumbers.Count; i++)
            {
                if (accountNumbers[i] == accountNum && pinNumbers[i] == pin && !userFound)
                {
                    userFound = true;
                    currentUser = i;
                    greetingLbl.Text = $"Welcome: {names[i]}";
                    balanceLbl.Text = $"Account Balance: {balances[i]}";
                }
            }

            if (userFound == false)
            {
                Logout();
                MessageBox.Show("Invalid account number or PIN.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Logout()
        {
            currentUser = -1;
            greetingLbl.Text = $"Welcome: ";
            balanceLbl.Text = $"Account Balance: ";
            accNumInput.Text = string.Empty;
            pinNumInput.Text = string.Empty;
        }

        private void MakeDeposit(decimal depositAmount)
        {
            if (currentUser != -1)
            {
                balances[currentUser] += depositAmount;
                balanceLbl.Text = $"Account Balance: {balances[currentUser]}";
                depositInput.Text = string.Empty;   
            }
        }

        private void MakeWithdrawl(decimal withdrawlAmount)
        {
            if (currentUser != -1)
            {
                balances[currentUser] -= withdrawlAmount;
                balanceLbl.Text = $"Account Balance: {balances[currentUser]}";
                withdrawInput.Text = string.Empty;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string accNum = accNumInput.Text;
            string pinNum = pinNumInput.Text;

            Login(accNum, pinNum);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            decimal userDeposit = decimal.Parse(depositInput.Text);
            MakeDeposit(userDeposit);
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            decimal userWithdraw = decimal.Parse(withdrawInput.Text);
            MakeWithdrawl(userWithdraw);
        }
    }
}
