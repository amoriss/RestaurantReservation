using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation
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
        public int Date { get; set; }
        public string Time { get; set; }
        public bool Booked { get; set; }
    }
}
