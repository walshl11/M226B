using ObjectOrientedDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Classes
{
    public class Reservation : IReservation
    {
        private IPerson _person;
        private IMovie _movie;
        private IEnumerable<ISeats> _seats;
        public string ReservationName { get; set; }
        public Reservation(string reservationName)
        {
            ReservationName = reservationName;
            _seats = new List<ISeats>();
        }

        public void PrintInformation()
        {
            Console.WriteLine($"Reservation {ReservationName} Details:");
            Console.WriteLine($"Person Name:\t{_person.GetName()}");
            Console.WriteLine($"Movie Name:\t{_movie.GetName()}");
            foreach (ISeats seats in _seats)
            {
                Console.WriteLine($"Seat {seats.GetSeatNumber()}{seats.GetRow()}");
            }
        }

        public void ReserveSeats(IPerson person, IMovie movie, int seatAmount)
        {
            _person = person;
            _movie = movie;

            for(int i = 0; i < seatAmount; i++)
            {
                Seat seat = new Seat();
                seat.SetRow("H");
                seat.SetSeatNumber(5);
                _seats = _seats.Append(seat);
                Console.WriteLine("New Reservation added successfully");
            }
        }

    }
}
