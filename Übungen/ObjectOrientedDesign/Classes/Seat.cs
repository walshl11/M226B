using ObjectOrientedDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Classes
{
    public class Seat : ISeats
    {
        private int _seatnumber;
        private string _seatrow;

        public string GetRow()
        {
            return _seatrow;
        }

        public int GetSeatNumber()
        {
            return _seatnumber;
        }

        public void PrintFullInfo()
        {
            Console.WriteLine("Seat info:");
            Console.WriteLine($"Seat row:\t{_seatrow}");
            Console.WriteLine($"Seat number:\t{_seatnumber}");
        }

        public void SetRow(string row)
        {
            _seatrow = row;
        }

        public void SetSeatNumber(int number)
        {
            _seatnumber = number;
        }
    }
}
