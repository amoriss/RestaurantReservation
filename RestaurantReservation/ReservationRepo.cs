using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation
{
    public class ReservationRepo: IReservationRepository
    {
        private readonly IDbConnection _conn;
        public IEnumerable<Reservation> GetReservations()
        {
            return _conn.Query<Reservation>("SELECT * FROM reservation.reserved;");
        }


    }
}
