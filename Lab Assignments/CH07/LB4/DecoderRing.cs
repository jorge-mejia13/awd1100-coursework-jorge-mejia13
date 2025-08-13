using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class DecoderRing
    {
        private int _shift;
        private string _innerRing;
        private string _outerRing;

        public DecoderRing() 
        {
            Shift = 0;
        }

        public string Decode(string text)
        {
            string uppercaseText = text.ToUpper();
            string result = "";

            for (int i = 0; i < uppercaseText.Length; i++)
            {
                if (!char.IsLetter(uppercaseText[i]))
                {
                    throw new InvalidCharacterException("Only letters A–Z are allowed.");
                }
                    
                int index = _innerRing.IndexOf(uppercaseText[i]);
                result += _outerRing[index];
            }

            return result;
        }

        public string Encode(string text)
        {
            string uppercaseText = text.ToUpper();
            string result = "";

            for (int i = 0; i < uppercaseText.Length; i++)
            {
                if (!char.IsLetter(uppercaseText[i]))
                {
                    throw new InvalidCharacterException("Invalid characters in a massage");
                }
                    

                int index = _innerRing.IndexOf(uppercaseText[i]);
                result += _outerRing[index];
            }

            return result;
        }

        public int Shift
        {
            get
            {
                return _shift;
            }
            set
            {
                if (value < 0 || value > 25)
                {
                    throw new InvalidCharacterException("Invalid Shift");
                }
                _shift = value;

                _innerRing = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                _outerRing = _innerRing.Substring(_shift) + _innerRing.Substring(0, _shift);
            }
        }
    }
}
