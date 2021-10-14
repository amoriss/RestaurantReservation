using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationApp.Models
{
    public class Reservation
    {

        public Reservation()
        {

        }
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Table_Size { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public bool Booked { get; set; } = false;
        public IEnumerable<TimeSlot> TimeSlots { get; set; }
    }
}
