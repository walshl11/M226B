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

        void SetName(string name);

        void PrintInfo();
    }
}
