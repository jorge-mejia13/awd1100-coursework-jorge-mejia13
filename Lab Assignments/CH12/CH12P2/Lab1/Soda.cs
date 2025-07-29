using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Soda
    {
        // instances
        public const double BASE_PRICE = 1.75;
        public const double FLAVOR_PRICE = 0.15;

        private SodaFlavor _flavor;
        private double _price;
        
        // properties
        public SodaFlavor Flavor { get => _flavor; }
        public double Price { get => _price; }

        public Soda()
        {
            _price += BASE_PRICE;
            _flavor = SodaFlavor.NONE;
        }
        public void AddFlavor(SodaFlavor f)
        {
            _flavor = f;
        }
    }
}
