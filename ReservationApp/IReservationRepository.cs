using ReservationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationApp
{
    public interface IReservationRepository
    {
        public IEnumerable<Reservation> GetReservations();
        public Reservation GetReservation(int id);
        public void InsertReservation(Reservation reservationToInsert);
        //public IEnumerable<TimeSlot> GetTimeSlots();
        public Reservation GetTimeSlots(Reservation reservation);
        void UpdateReservation(Reservation res);
        public void DeleteReservation(Reservation reservation);

    }
}
