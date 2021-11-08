using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesign.Interfaces;

namespace ObjectOrientedDesign.Classes
{
    public class PersonBase : IPerson
    {
        private string _name;

        public PersonBase(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Details of Person {_name}:");
            Console.WriteLine($"Name:\t{_name}");
        }
    }
}
