using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Computer
    {
        private string _name;
        private string _iPAddress;
        private string[] _services;

        public Computer(string name, string iPAddress, string[] services)
        {
            _name = name;
            _iPAddress = iPAddress;
            _services = services;
        }

        public string Name
        {
            get => _name;
        }

        public string IpAddress
        {
            get => _iPAddress;  
        }

        public string[] Services
        {
            get => _services;
        }
    }
}
