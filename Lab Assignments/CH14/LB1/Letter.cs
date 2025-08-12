using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Letter
    {
        // instances
        protected string _repient;
        protected DateTime _sentDate;

        // constructor
        public Letter(string recipient, DateTime sentDate)
        {
            _repient = recipient;
            _sentDate = sentDate;
        }

        // override method
        public override string ToString()
        {
            return $"{_sentDate.ToString("d")}, {_repient}, {Price.ToString("C")}";
        }

        // properties
        public string Recipient { get { return _repient; } }
        public DateTime SentDate { get { return _sentDate; } }
        public virtual double Price 
        {  
            get 
            { 
                return 0.50; 
            } 
        }
    }
}
