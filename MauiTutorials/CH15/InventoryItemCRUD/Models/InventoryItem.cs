using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryItemCRUD.Models
{
    public class InventoryItem(int itemNo, string description, decimal price) : INotifyPropertyChanged
    {
        private int _itemNo = itemNo;
        private string _description = description;
        private decimal _price = price;

        public int ItemNo
        {
            get => _itemNo;
            set
            {
                _itemNo = value;
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemNo"));
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
            }
        }
        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PriceDisplay"));
            }
        }
        public string PriceDisplay => _price.ToString("C");

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
