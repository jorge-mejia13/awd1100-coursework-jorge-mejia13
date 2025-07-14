using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Room
    {
        private string _name;
        private int _width;
        private int _length;
        private int _area;
        private int _boxes;

        // constructor
        public Room(string name, int width, int length)
        {
            _name = name;
            _width = width;
            _length = length;
        }

        // method
        public string Display()
        {
            return $"{_name} ({_width}x{_length}) needs {_boxes} boxes";
        }

        // properties
        public string Name
        {
            get => _name;
        } 

        public int Width
        {
            get => _width;
        }

        public int Length
        {
            get => _length;
        }

        public int Area
        {
           get
           {
                return _width * _length;
           }
        }

        public int Boxes
        {
            get
            {
                return (_area / 12) + 2;
            }
        }
    }
}
