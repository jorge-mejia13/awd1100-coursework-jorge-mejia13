using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        List<Conference> conferences = new List<Conference>();

        Conference conference;
        public Form1()
        {
            InitializeComponent();
        }

       
        int attendeesCount = 0;


        private void addBtn_Click(object sender, EventArgs e)
        {
            string groupName = groupNameInput.Text;
            string startingTime = startingTimeInput.Text;
            string attendees = attendeesInput.Text;
            int room = int.Parse(roomInput.Text);

            conference = new Conference();
            conference.GroupName = groupName;
            conference.StartingDate = DateTime.Parse(startingTime);
            conference.Attendees = int.Parse(attendees);

            if (room == 101) { conference.Room = Room.ROOM_101; }
            if (room == 102) { conference.Room = Room.ROOM_102; }
            if (room == 201) { conference.Room = Room.ROOM_201; }
            if (room == 202) { conference.Room = Room.ROOM_202; }
            if (room == 301) { conference.Room = Room.ROOM_301; }
            if (room == 302) { conference.Room = Room.ROOM_302; }

            // adds conference to the array
            conferences.Add(conference);

            // displays new conference
            displayLbl.Text += $"\n{conference.Display()}\n";
            conferenceLbl.Text = $"Conferences: {conferences.Count}/20";
            attendeesCount += conference.Attendees;
            attendeesLbl.Text = $"Attendees: {attendeesCount}";
            
            // clears out the inputs
            groupNameInput.Text = String.Empty;
            startingTimeInput.Text = String.Empty; 
            attendeesInput.Text = String.Empty;
            roomInput.Text = String.Empty;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string beginDate = beginInput.Text;
            string endDate = endInput.Text;

            displayLbl.Text = String.Empty;

            for (int i = 0; i < conferences.Count; i++)
            {
                if (conferences[i].StartingDate >= DateTime.Parse(beginDate) && conferences[i].StartingDate <= DateTime.Parse(endDate))
                {
                    displayLbl.Text += $"\n{conferences[i].Display()}\n";
                }
            }

        }
    }
}
