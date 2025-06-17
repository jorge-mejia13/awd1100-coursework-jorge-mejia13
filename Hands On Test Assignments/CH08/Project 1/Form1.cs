using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> firstNames = new List<string> { "Markel", "Luiza", "Bryony", "Giraldo", "Lowri" };
        List<string> lastNames = new List<string> { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };
        List<string> phoneNumbers = new List<string> { "555-8390", "555-4618", "555-4440", "555-1687", "555-7763" };


        private void searchBtn_Click(object sender, EventArgs e)
        {
            string nameSearched = nameInput.Text;

            bool found = false;
            
            for (int i = 0; i < firstNames.Count; i++)
            {
                if (firstNames[i].ToLower().Contains(nameSearched.ToLower()) || lastNames[i].ToLower().Contains(nameSearched.ToLower()))
                {
                    firstNameLbl.Text = $"First Name: {firstNames[i]}";
                    lastNameLbl.Text = $"Last Name: {lastNames[i]}";
                    phoneNumberLbl.Text = $"Phone #: {phoneNumbers[i]}";
                    nameInput.Text = string.Empty;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                firstNameLbl.Text = $"First Name: Error";
                lastNameLbl.Text = $"Last Name: Error";
                phoneNumberLbl.Text = $"Phone #: Error";
            }
        }
    }
}
