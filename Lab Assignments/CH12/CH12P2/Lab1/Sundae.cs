using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Sundae
    {
        public const double BASE_PRICE = 4.50;
        public const double TOPPING_PRICE = 0.50;

        private SundaeTopping[] _toppings;
        private int _toppingCount;
        private double _price;

        // properties
        public int ToppingCount { get => _toppingCount; }
        public double Price { get => _price; }

        // constructor
        public Sundae()
        {
            _toppingCount = 0;
            _price = _price + BASE_PRICE;
            _toppings = new SundaeTopping[4];
            _toppings[0] = SundaeTopping.NONE;
        }
        public SundaeTopping GetTopping(int index)
        {
            return _toppings[index];
        }
        public void AddTopping(SundaeTopping t) 
        {
            _toppings[_toppingCount] = t;
            _toppingCount++;
            _price += TOPPING_PRICE;
        }
    }
}
