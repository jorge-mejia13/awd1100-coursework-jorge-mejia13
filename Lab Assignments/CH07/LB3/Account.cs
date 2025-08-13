using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public class Account
    {
        private string _username;
        private string _password;
        private string _firstName;
        private bool _disabled;

        public Account(string username, string password, bool disabled)
        {
            _username = username;
            _password = password;
            _disabled = disabled;
        }

        public string Username { get { return _username; } }
        public string Password { get { return _password; } }
        public bool IsDisabled { get { return _disabled; } }
    }
}
