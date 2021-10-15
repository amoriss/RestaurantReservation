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
        public string Time { get; set; }
        
        public bool Booked { get; set; } = false;
        public List<string> TimeSlots { get; set; } = new List<string> { "4:00 pm", "4:15 pm", "4:30 pm", "4:45 pm", "5:00 pm", "5:15 pm", "5:30 pm", "5:45 pm", "6:00 pm", "6:00 pm", "6:15 pm", "6:30 pm", "6:45 pm", "7:00 pm", "7:15 pm", "7:30 pm", "7:40 pm", "7:50 pm", };

        public string DateParse()
        {

            return Date.ToString().Substring(0, 10);
        }
    }
}
