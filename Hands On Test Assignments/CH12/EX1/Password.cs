﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    internal class Password
    {
        private string _raw;
        private string _hash;

        public Password() {}

        public Password(string raw, string hash)
        {
            _raw = raw;
            _hash = hash;
        }

        public string Raw
        {
            get => _raw;
        }

        public string Hash
        {
            get => _hash;
        }
    }
}
