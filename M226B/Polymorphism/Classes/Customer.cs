using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Classes
{
    public class Customer: Person
    {
        public Customer() : base()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
