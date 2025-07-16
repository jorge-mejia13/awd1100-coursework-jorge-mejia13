using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        List<Computer> computers = new List<Computer>
        {
            new Computer("My-Desktop", "127.0.0.1", new string[] {"20", "21", "23", "25", "53", "80", "123", "389", "443"}),
            new Computer("google-public", "8.8.8.8", new string[] {"53"}),
            new Computer("ranken.edu", "47.44.246.80", new string[] {"23", "80", "443"})
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void scanBtn_Click(object sender, EventArgs e)
        {
            string address = ipAddressInput.Text;
            Computer computer = ScanIpAddress(address);
            ShowComputer(computer);
        }

        private Computer ScanIpAddress(string ipAddress)
        {
            for (int i = 0; i < computers.Count; i++)
            {
                if (computers[i].IpAddress == ipAddress)
                {
                    return computers[i];
                }
            }
            return null;
        }

        private void ShowComputer(Computer computer)
        {
            if (computer == null)
            {
                myDesktopResultLbl.Text = $"Services: None";
            }
            else
            {
                myDesktopResultLbl.Text = $"Name: {computer.Name}\n" + $"IP Address: {computer.IpAddress}\n" + $"Services: {string.Join(", ", computer.Services)}";
            }
               
        }
    }
}
