using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Classes
{
    public class Actor : Person
    {
        public override void Greet()
        {
            Console.WriteLine($"Hello I am a Actor, my name is {GetName()}");
        }

        public Actor(string firstname, string surname, int age) : base(firstname, surname, age)
        {

        }
    }
}
