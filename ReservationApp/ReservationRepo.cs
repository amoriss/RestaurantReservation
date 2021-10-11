using Dapper;
using ReservationApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationApp
{
    public class ReservationRepo: IReservationRepository
    {

        private readonly IDbConnection _conn;
        public ReservationRepo(IDbConnection conn)
        {
            _conn = conn; 
        }        

        public IEnumerable<Reservation> GetReservations()
        {
            //throw new NotImplementedException();
            return _conn.Query<Reservation>("SELECT * FROM RESERVED;");
        }
        public Reservation GetReservation(int id)
        {
            
                return _conn.QuerySingle<Reservation>("SELECT * FROM RESERVED WHERE ID = @id",
                    new { id = id });      
           // throw new NotImplementedException();
        }

        public void UpdateReservation(Reservation reservation)
        {
            _conn.Execute("UPDATE reserved SET First_Name = @first_name, Last_Name = @last_name, Date = @date, " +
                "Time = @time, Table_Size = @table_size, TABLE_BOOKED = @table_booked WHERE ID = @id",
                new { first_name =reservation.First_Name, last_name = reservation.Last_Name, date = reservation.Date, 
                    time = reservation.Time, table_size = reservation.Table_Size, id = reservation.ID });
        }

        public void InsertProduct(Reservation reservationToInsert)
        {
            {
                _conn.Execute("INSERT INTO reservation (FIRST_NAME, LAST_NAME, DATE, TIME, TABLE_SIZE, ID) VALUES (@first_name, @last_name," +
                    "@date, @time, @table_size, @ID);",
                    new { date = reservationToInsert.Date, time = reservationToInsert.Time, ID = reservationToInsert.ID });
            }

        }

        public IEnumerable<TimeSlot> GetTimeSlots()
        {
            return _conn.Query<TimeSlot>("SELECT * FROM reservation;");
        }


        public Reservation AssignTimeSlot()
        {
            var reservationList = GetReservations();
            var reservation= new Reservation();
            reservation.TimeSlots = reservationList;

            return reservation;
        }

        public void DeleteReservation(Reservation reservation)
        {
            _conn.Execute("DELETE FROM RESERVED WHERE ID = @id;",
                                       new { id = reservation.ID });
            
        }

        
    }
}
