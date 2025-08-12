using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public class Account
    {
        protected double _balance;
        protected double _minBalance;
        protected string _type;
        protected List<string> _transactions = new List<string>();

        public string Name { get; }
        public string AccountNumber { get; }
        public string PinNumber {  get; }
        public string Type { get => _type; }
       

        public Account(string name, string acc, string pin, double balance)
        {
            Name = name;
            AccountNumber = acc;
            PinNumber = pin;
            _balance = balance;
            _minBalance = 0;
            _type = "bronze";
        }

        // make deposit method
        public virtual void MakeDeposit(double amount)
        {
            _balance += amount;
            _transactions.Add($"Deposit: ${amount}");
        }

        // make withdrawal method
        public virtual void MakeWithdraw(double amount)
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
                MessageBox.Show($"You are going below the minumum of {_minBalance} in your account");
            }
        }

        public void ShowTransactions()
        {
            string statement = "";

            for (int i = 0; i < _transactions.Count; i++)
            {
                statement += $"{_transactions[i]}\n";
            }
            MessageBox.Show(statement);
        }
        public override string ToString()
        {
            return $"Welcome: {Name}\n" + $"Your account balance is: ${_balance}\n" + $"Account Type: Bronze";
        }
    }
}
