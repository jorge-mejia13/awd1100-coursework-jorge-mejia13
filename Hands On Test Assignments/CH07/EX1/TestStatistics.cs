using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class TestStatistics
    {
        private int _count;
        private float _sum;
        private float _avg;
        private float _min;
        private float _max;

        public TestStatistics()
        {
            _count = 0;
            _sum = 0;
            _avg = 0;
            _min = 100;
            _max = 0;
        }

        public void AddScore(float score)
        {
            if (score < 0 || score > 100)
            {
                throw new ArgumentException("Not in range");
            }
            _count++;
            _sum += score;
            _avg = _sum / _count;

            if (score < _min)
            {
                _min = score;
            }
            if (score > _max)
            {
                _max = score;
            }

            
        }

        public int Count
        {
            get { return _count; }
        }

        public float Sum
        {
            get { return _sum; }
        }

        public float Average
        {
            get { return _avg; }
        }

        public float Min
        {
            get { return _min; }
        }

        public float Max
        {
            get { return _max; }
        }
    }
}
