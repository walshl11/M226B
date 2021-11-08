using ObjectOrientedDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Classes
{
    public abstract class Person : IPerson
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string FullName { get; set; }

        public virtual void Greet()
        {
            Console.WriteLine("Hello I am an unidentified Person.");
        }

        public Person()
        {
            SetFullName();
        }

        public void SetFullName()
        {
            FullName = FirstName + " " + SurName;
        }
    }
}
