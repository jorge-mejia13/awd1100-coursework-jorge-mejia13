using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public class NormalCard
    {
        private string _name;
        private Image _image;
        private double _value;

        public NormalCard(string name, Image image, double value)
        {
            _name = name;
            _image = image;
            _value = value;
        }

        public void ShowCard(PictureBox picture, Label label)
        {

        }

        public string Name { get { return _name; } }
        public double Value { get { return _value; } }
        public Image Image { get { return _image; } }
    }
}
