using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Ability
    {
        // instance
        private string _name;

        // constructor
        public Ability(string name)
        {
            _name = name;
        }

        // gettter property
        public string Name 
        { 
            get 
            { 
                return _name; 
            }         
        }
    }
}
