using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public partial class Form1 : Form
    {
        List<Account> accounts = new List<Account>();

        Account currentAccount = null;

        public Form1()
        {
            InitializeComponent();

            accounts.Add(new Account("Jorge", "1212", "1234", 1000));
            accounts.Add(new GoldAccount("Lionel", "1313", "5432", 1000000));
            accounts.Add(new SilverAccount("Jon", "1414", "5678", 2500));
            accounts.Add(new Account("Ed", "1515", "9876", 200));
            accounts.Add(new GoldAccount("Mark", "1616", "1010", 5000));
        }

        // login
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (currentAccount == null)
            {
                string accountNumber = accNumberInput.Text.Trim();
                string pinNumber = pinNumberInput.Text.Trim();

                for (int i = 0; i < accounts.Count; i++)
                {
                    if (accounts[i].AccountNumber == accountNumber && accounts[i].PinNumber == pinNumber)
                    {
                       currentAccount = accounts[i];
                       break;
                    }
                }

                accInfoLbl.Text = currentAccount.ToString();
            } 
            else
            {
                MessageBox.Show("User already logged in.");
            }
        }

        // logout
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            currentAccount = null;
            accNumberInput.Text = string.Empty;
            pinNumberInput.Text = string.Empty;
            accInfoLbl.Text = string.Empty;
        }

        // deposit
        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (currentAccount != null)
            {
                double depositAmount = double.Parse(depositInput.Text);
                currentAccount.MakeDeposit(depositAmount);
                depositInput.Text = string.Empty;
                accInfoLbl.Text = currentAccount.ToString();
            }
            else
            {
                MessageBox.Show("You need to be logged in");
            }
        }

        // withdraw
        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (currentAccount != null)
            {
                double withdrawAmount = double.Parse(withdrawInput.Text);

                currentAccount.MakeWithdraw(withdrawAmount);
                withdrawInput.Text = string.Empty;
                accInfoLbl.Text = currentAccount.ToString();
            }
            else
            {
                MessageBox.Show("You need to be logged in");
            }
        }

        // view or print statement transactions
        private void statementBtn_Click(object sender, EventArgs e)
        {
            if (currentAccount.Type == "silver" || currentAccount.Type == "gold")
            {
                currentAccount.ShowTransactions();
            }
            else
            {
                MessageBox.Show("Your account cannot view statments");
            }
        }
    }
}
