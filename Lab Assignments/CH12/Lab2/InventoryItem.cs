using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class InventoryItem
    {
        private string _itemName;
        private int _upc;
        private decimal _price;
        private decimal _costPerCase;
        private int _unitsPerCase;


        // constructor
        public InventoryItem(string itemName, int upc, decimal price, decimal costPerCase, int unitsPerCase)
        {
            _itemName = itemName;
            _upc = upc;
            _price = price;
            _costPerCase = costPerCase;
            _unitsPerCase = unitsPerCase;
        }

        public void SetItemName(string itemName)
        {
            _itemName = itemName;
        }

        public string GetItemName()
        {
            return _itemName;
        }

        public void SetUpc(int upc)
        {
            _upc = upc;
        }

        public int GetUpc()
        {
            return _upc;
        }

        public void SetPrice(decimal price)
        {
            _price = price;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public void SetCostPerCase(decimal costPerCase)
        {
            _costPerCase = costPerCase;
        }

        public decimal GetCostPerCase()
        {
            return _costPerCase;
        }

        public void SetUnitsPerCase(int unitsPerCase)
        {
            _unitsPerCase = unitsPerCase;
        }

        public int GetUnitsPerCase()
        {
            return _unitsPerCase;
        }
    }
}
