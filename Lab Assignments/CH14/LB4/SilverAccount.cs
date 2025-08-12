using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public class SilverAccount : Account
    {
        public SilverAccount(string name, string acc, string pin, double balance) : base(name, acc, pin, balance)
        {
            _minBalance = 1000;
            _type = "silver";
        }

        public override void MakeWithdraw(double amount)
        {
            double fee = amount * 0.01;
            double totalAmount = amount + fee;


            if ((_balance - totalAmount) >= _minBalance)
            {
                _balance -= totalAmount;
                _transactions.Add($"Withdraw: ${amount}");
            }
            else
            {
                MessageBox.Show($"You are going below the minumum of ${_minBalance} in your account");
            }
        }

        public override string ToString()
        {
            return $"Welcome: {Name}\n" + $"Your account balance is: ${_balance}\n" + $"Account Type: Silver";
        }
    }
}
