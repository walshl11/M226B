using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Classes
{
    public abstract class Employee : Person
    {
        public object Location { get; set; }

        protected Employee() : base()
        {

        }
    }
}
