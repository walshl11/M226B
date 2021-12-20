using ObjectOrientedDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubTest.Class
{
    public class PersonStub : IPerson
    {
        public int GetAge()
        {
            return 25;
        }

        public string GetName()
        {
            return "Test name";
        }

        public void Greet()
        {
            Console.WriteLine("greet");
        }

        public void PrintOutInformation()
        {
            Console.WriteLine("print info");
        }

        public IReservation ReserveMovieSeats(IMovie movie, int seatAmount)
        {
            throw new NotImplementedException();
        }

        public void SetAge(int age)
        {
            Console.WriteLine("set age");
        }

        public void SetName(string firstname, string surname)
        {
            Console.WriteLine("set name");
        }
    }
}
