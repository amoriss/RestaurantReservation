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
                "Time = @time, Table_Size = @table_size WHERE ID = @id;",
                new { first_name =reservation.First_Name, last_name = reservation.Last_Name, date = reservation.Date, 
                    time = reservation.Time, table_size = reservation.Table_Size, id = reservation.ID });
        }

        public void InsertReservation(Reservation reservationToInsert)
        {
            {
                _conn.Execute("INSERT INTO reserved (FIRST_NAME, LAST_NAME, DATE, TIME, TABLE_SIZE, BOOKED, ID) VALUES (@first_name, @last_name," +
                    "@date, @time, @table_size, @booked, @ID);",
                    new { first_name = reservationToInsert.First_Name, last_name = reservationToInsert.Last_Name, date = reservationToInsert.Date, 
                        time = reservationToInsert.Time, table_size = reservationToInsert.Table_Size, booked= true, ID = reservationToInsert.ID });
            }

        }

        public Reservation GetTimeSlots(Reservation reservation)
        {
            var slots = _conn.Query<TimeSlot>("SELECT Time FROM reserved Where Date like @date;",
                new {date = reservation.Date });

            var reservation2 = new Reservation();
            reservation2.TimeSlots = slots;
            return reservation2;
        }

     

      
        public void DeleteReservation(Reservation reservation)
        {
            _conn.Execute("DELETE FROM RESERVED WHERE ID = @id;",
                                       new { id = reservation.ID });
            
        }

       
    }
}
