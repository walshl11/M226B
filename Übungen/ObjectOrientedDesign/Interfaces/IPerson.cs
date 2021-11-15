using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Interfaces
{
    public interface IPerson
    {
        string GetName();

        int GetAge();

        void SetName(string firstname, string surname);

        void PrintOutInformation();

        void Greet();

        void SetAge(int age);

        IReservation ReserveMovieSeats(IMovie movie, int seatAmount);
    }
}
