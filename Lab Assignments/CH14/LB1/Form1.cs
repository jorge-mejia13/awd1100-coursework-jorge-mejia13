using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        List<Letter> letters = new List<Letter>(20);
        public Form1()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        { 
            if (recipientInput.Text != "" && sentDateInput.Text != "" && trackingNumberInput.Text != "")
            {
                errorLbl.Text = string.Empty;

                CertifiedLetter certifiedLetter = new CertifiedLetter(recipientInput.Text, DateTime.Parse(sentDateInput.Text), trackingNumberInput.Text);

                letters.Add(certifiedLetter);

                resultLbl.Text = string.Empty;

                for (int i = 0; i < letters.Count; i++)
                {
                    resultLbl.Text += $"{letters[i].ToString()}\n";
                }
            }
            else if (recipientInput.Text != "" &&  sentDateInput.Text != "" && trackingNumberInput.Text == "")
            {
                errorLbl.Text = string.Empty;

                Letter letter = new Letter(recipientInput.Text, DateTime.Parse(sentDateInput.Text));

                letters.Add(letter);

                resultLbl.Text = string.Empty;

                for (int i = 0; i < letters.Count; i++)
                {
                    resultLbl.Text += $"{letters[i].ToString()}\n";
                }
            }
            else
            {
                errorLbl.Text = "Please enter a recipient and date";
            }
        }
    }
}
