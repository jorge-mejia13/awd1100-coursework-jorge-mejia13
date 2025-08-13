using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class Order
    {
        private short _itemNumber;
        private byte _quantity;
        private byte _estimatedDeliveryDays;

        public Order(short itemNumber, byte quantity, byte estimatedDeliveryDays) 
        { 
            ItemNumber = itemNumber;
            Quantity = quantity;
            EstimatedDeliveryDays = estimatedDeliveryDays;
        }

        public short ItemNumber
        {
            get { return _itemNumber; }
            set 
            { 
                if (value < 100 || value > 999)
                {
                    throw new InvalidItemNumberException("Item number is not within range");
                }
                else
                {
                    _itemNumber = value;
                }
            }
        }

        public byte Quantity
        {
            get { return _quantity; } 
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new InvalidQuantityException("Invalid quantity amount");
                }
                else
                {
                    _quantity = value;
                }
            }
        }

        public byte EstimatedDeliveryDays
        {
            get { return _estimatedDeliveryDays; }
            set
            {
                if (value < 1 || value > 30)
                {
                    throw new InvalidDeliveryDaysException("Invalid delivery days");
                }
                else
                {
                    _estimatedDeliveryDays = value;
                }
            }
        }
    }
}
