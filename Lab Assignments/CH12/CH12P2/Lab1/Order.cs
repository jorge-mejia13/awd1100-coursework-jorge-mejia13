using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Order
    {
        // instances
        private string _name;
        private Sundae _sundae;
        private Soda _soda;

        // properties
        public string Name { get => _name; }
        public Sundae Sundae { get => _sundae; }
        public Soda Soda { get => _soda; }
        public double Price
        {
            get
            {
                double price = 0;

                if (_soda == null)
                {
                    price = _sundae.Price;
                }
                else if (_sundae == null)
                {
                    price = _soda.Price;
                }
                else
                {
                    price = _sundae.Price + _soda.Price;
                }

                return price;
            }
        }

        // constructor
        public Order(string name, bool hasSundae, bool hasSoda)
        {
            _name = name;
            if (hasSundae)
            {
                _sundae = new Sundae();
            }

            if (hasSoda)
            {
                _soda = new Soda();
            }
        }  
    }
}
