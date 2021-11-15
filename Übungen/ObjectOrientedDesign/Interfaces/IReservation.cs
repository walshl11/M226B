using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Interfaces
{
    public interface IReservation
    {
        void ReserveSeats(IPerson person, IMovie movie, int seatamount);

        void PrintInformation();
    }
}
