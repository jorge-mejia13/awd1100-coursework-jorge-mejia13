using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Conference
    {
        // auto implemented properties
        public string GroupName { get; set; }
        public DateTime StartingDate { get; set; }
        public int Attendees { get; set; }
        public Room Room { get; set; }

        // method
        public string Display()
        {
            return $"({Attendees}) {GroupName} on {StartingDate} in Room {(int)Room}";
        }
    }
}
