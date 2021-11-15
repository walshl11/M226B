using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Interfaces
{
    public interface ISeats
    {
        void PrintFullInfo();
        string GetRow();
        int GetSeatNumber();
        void SetRow(string row);
        void SetSeatNumber(int number);
    }
}
