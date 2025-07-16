using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        List<Password> passwords = new List<Password>
        {
            new Password("12345", "827ccb0eea8a706c4c34a16891f84e7b"),
            new Password("hello", "5d41402abc4b2a76b9719d911017c592"),
            new Password("admin", "21232f297a57a5a743894a0e4a801fc3"),
            new Password("test1", "5a105e8b9d40e1329780d62ea2265d8a"),
            new Password("qwert", "d8578edf8458ce06fbc5bb76a58c5ca4")
        };
        public Form1()
        {
            InitializeComponent();
        }

        private string CrackPassword(string hash)
        { 
            for (int i = 0; i < passwords.Count; i++)
            {
                if (passwords[i].Hash == hash)
                {
                    return passwords[i].Raw;
                }
            }

            return "FAIL";
        }

        private void hashBtn_Click(object sender, EventArgs e)
        {
            string hash = hashInput.Text;
            string result = CrackPassword(hash);

            resultLbl.Text = result;
        }
    }
}
