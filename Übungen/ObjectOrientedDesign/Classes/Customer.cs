using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Classes
{
    public class Customer : Person
    {
        public override void Greet()
        {
            Console.WriteLine($"Hello I am a Costumer, my name is {FullName}");
        }
        public Customer() : base()
        {
           
        }
    }
}
