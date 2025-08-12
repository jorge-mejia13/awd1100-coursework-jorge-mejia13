using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class LongTermLoan : ILoan
    {
        private string _name;
        private double _balance;

        public LongTermLoan(string name, double balance)
        {
            _name = name;
            _balance = balance;
            Type = "Long-Term Loan";
        }

        public string Name { get { return _name; } }
        public string Type { get; }
        public double Balance { get { return _balance; } }

        public void ApplyInterest()
        {
            double interestFee = _balance * 0.05;
            _balance += interestFee;
        }

        public void MakePayment()
        {
            _balance = _balance - 200;
        }
    }
}
