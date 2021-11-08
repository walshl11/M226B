using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Classes
{
    public class Reservation
    {
        public Customer Customer { get; set; }
        public Movie Movie { get; set; }
        public IEnumerable<Seat> Seats { get; set; }
    }
}
