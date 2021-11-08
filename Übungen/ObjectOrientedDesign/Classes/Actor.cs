using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Classes
{
    public class Actor : Person
    {
        public IEnumerable<Movie> Movies { get; set; }

        public override void Greet()
        {
            Console.WriteLine($"Hello I am an Actor, my name is {FullName}");
        }
        public Actor() : base()
        {

        }
    }
}
