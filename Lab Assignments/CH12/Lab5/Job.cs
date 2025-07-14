using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Job
    {
        public double TRIP_FEE = 35;
        private string _description;
        private float _hoursToComplete;
        private float _hourlyFee;
        private float _totalFee;

        public Job(string description, float hoursToComplete, float hourlyFee)
        {
            _description = description;
            _hoursToComplete = hoursToComplete;
            _hourlyFee = hourlyFee;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public float HoursToComplete
        {
            get => _hoursToComplete;
            set
            {
                _hoursToComplete = value;
                _totalFee = (value * _hourlyFee) + (float)TRIP_FEE;
            }
        }

        public float HourlyFee
        {
            get => _hourlyFee;
            set
            {
                _hourlyFee = value;
                _totalFee = (value * _hoursToComplete) + (float)TRIP_FEE;
            }
        }

        public double TotalFee
        {
            get => _totalFee;
        }

       
    }
}
