using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation
{
    public interface IReservationRepository
    {
        public IEnumerable<Reservation> GetReservations();
    }
}
