using System;
using System.Collections.Generic;

namespace ReservationApp.Models
{
    public class TimeSlot
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }        
        public IEnumerable<TimeSlot> TimeSlots { get; set; }

    }
}

