using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public class BankForm1 : Form
    {
        List<Account> accounts = new List<Account>()
        {
            new Account("jorge", "ready", false),
            new Account("leo", "pass", true),
            new Account("jon", "word", false),
            new Account("smith", "water", true),
            new Account("amy", "pass", false)
        };

        public Account Login(string username, string password)
        {
            if (username == null || password == null)
            {
                throw new NoUsernamePasswordException("You must enter a username and password");
            }

            for (int i = 0; i < accounts.Count; i++)
            {
                if (username == accounts[i].Username && password == accounts[i].Password)
                {
                    if (accounts[i].IsDisabled)
                    {
                        throw new AccountDisabledException("Account is disabled");
                    }

                    return accounts[i];
                }
            }

            throw new IncorrectPasswordException("Incorrect Username/Password");
        }
    }
}
