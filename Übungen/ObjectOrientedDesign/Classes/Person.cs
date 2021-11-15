using ObjectOrientedDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Classes
{
    public class Person : IPerson
    {
        private string _firstname;
        private string _surname;
        private int _age;

        public Person(string firstname, string surname, int age)
        {
            _firstname = firstname;
            _surname = surname;
            _age = age;
        }

        public int GetAge()
        {
            return _age;
        }

        public string GetName()
        {
            return _firstname + " " + _surname;
        }

        public virtual void Greet()
        {
            Console.WriteLine("Hello I am an unidentified Person.");
        }

        public void PrintOutInformation()
        {
            Console.WriteLine($"Person {_firstname + " " + _surname}:");
            Console.WriteLine($"Name:\t {_firstname + " " + _surname}");
            Console.WriteLine($"Age:\t {_age}");
        }

        public IReservation ReserveMovieSeats(IMovie movie, int seatAmount)
        {
            string reservationName = $"New Reservation for {GetName()}";
            IReservation newReservation = new Reservation(reservationName);

            newReservation.ReserveSeats(this, movie, seatAmount);

            return newReservation;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public void SetName(string firstname, string surname)
        {
            _firstname = firstname;
            _surname = surname;
        }
    }
}
