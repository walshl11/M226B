using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Interfaces
{
    public interface IMovie
    {
        string GetName();
        void SetName(string name);
        List<IPerson> GetCast();
        void AddToCast(IPerson person);
    }
}
