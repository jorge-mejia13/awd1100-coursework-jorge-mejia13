using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        Room[] rooms = new Room[20]; 
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;
        int totalBoxesCounter = 0;
        int index = -1;

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            int width = int.Parse(widthInput.Text);
            int length = int.Parse(lengthInput.Text);

            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] == null)
                {
                    rooms[i] = new Room(name, width, length);
                    count++;
                    index = i;
                    roomsList.Items.Add(rooms[i].Display());
                    totalBoxesCounter = totalBoxesCounter + rooms[i].Boxes;
                    break;
                }
            }

            roomsCountLbl.Text = $"Rooms: {count}/20";
            totalBoxesNeededLbl.Text = $"Total Boxes Needed: {totalBoxesCounter}";
            nameInput.Text = string.Empty;
            widthInput.Text = string.Empty; 
            lengthInput.Text = string.Empty;
        }
    }
}
