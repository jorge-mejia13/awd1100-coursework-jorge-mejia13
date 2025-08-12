using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public class GoldAccount : Account
    {
        public GoldAccount(string name, string acc, string pin, double balance) : base(name, acc, pin, balance)
        {
            _minBalance = 5000;
            _type = "gold";
        }

        public override void MakeWithdraw(double amount)
        {
            if ((_balance - amount) >= _minBalance)
            {
                _balance -= amount;
                _transactions.Add($"Withdraw: ${amount}");
            }
            else
            {
                MessageBox.Show($"You are going below the minumum of ${_minBalance} in your account");
            }
        }

        public override string ToString()
        {
            return $"Welcome: {Name}\n" + $"Your account balance is: ${_balance}\n" + $"Account Type: Gold";
        }
    }
}
