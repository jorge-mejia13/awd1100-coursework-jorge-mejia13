using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DecoderRing ring = new DecoderRing();
                ring.Shift = int.Parse(shiftInput.Text);

                string encodeText = encodeInput.Text;
                string output = ring.Encode(encodeText);

                decodeInput.Text = output;
                encodeInput.Text = string.Empty;
            }
            catch (InvalidCharacterException ex)
            {
                encodeErrorLbl.Text = ex.Message;   
            }
        }

        private void decodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DecoderRing ring = new DecoderRing();
                ring.Shift = int.Parse(shiftInput.Text);

                string decodeText = decodeInput.Text;
                string output = ring.Decode(decodeText);

                encodeInput.Text = output;
                decodeInput.Text = string.Empty;

            }
            catch (InvalidCharacterException ex)
            {
                decodeErrorLbl.Text = ex.Message;
            }
        }
    }
}
