using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        Account[] accounts = new Account[5];
        public Form1()
        {
            InitializeComponent();

            accounts[0] = new Account("100001", "4321", "Alice Johnson", 1250.75m);
            accounts[1] = new Account("100002", "1234", "Bob Smith", 980.50m);
            accounts[2] = new Account("100003", "5678", "Cathy Lee", 3420.00m);
            accounts[3] = new Account("100004", "2468", "David Kim", 275.25m);
            accounts[4] = new Account("100005", "1357", "Emma Brown", 10250.10m);
        }

        int currentIndex = -1;

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string accNumber = accInput.Text;
            string pinNumber = pinInput.Text;

            Login(accNumber, pinNumber);
        }

        private void Login(string accNumber, string pinNumber)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].GetAccountNumber() == accNumber && accounts[i].GetPin() == pinNumber)
                {
                    welcomeLbl.Text = $"Welcome: {accounts[i].GetName()}";
                    balanceLbl.Text = $"Your account balance is: ${accounts[i].GetBalance()}";
                    currentIndex = i;
                    return;
                }
            }

            welcomeLbl.Text = "User not found";
            balanceLbl.Text = string.Empty;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Logout();   
        }

        private void Logout()
        {
            currentIndex = -1;
            welcomeLbl.Text = "User logged out";
            accInput.Text = string.Empty;
            pinInput.Text = string.Empty;
            balanceLbl.Text = string.Empty;
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            decimal depositAmount = decimal.Parse(depositInput.Text);

            MakeDeposit(depositAmount);
        }


        private void MakeDeposit(decimal amount)
        {
            if (currentIndex != -1)
            {
                decimal currentBalance = accounts[currentIndex].GetBalance();
                decimal newBalance = currentBalance + amount;
                balanceLbl.Text = $"Your account balance is: ${newBalance.ToString()}";
                depositInput.Text = string.Empty;
            }
            else
            {
                welcomeLbl.Text = "User not found";
            }
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            decimal withdraAmount = decimal.Parse(withdrawInput.Text);

            MakeWithdrawal(withdraAmount);
        }

        private void MakeWithdrawal(decimal amount)
        {
            if (currentIndex != -1)
            {
                decimal currentBalance = accounts[currentIndex].GetBalance();
                decimal newBalance = currentBalance - amount;
                balanceLbl.Text = $"Your account balance is: ${newBalance.ToString()}";
                withdrawInput.Text = string.Empty;
            }
            else
            {
                welcomeLbl.Text = "User not found";
            }
        }


    }
}
