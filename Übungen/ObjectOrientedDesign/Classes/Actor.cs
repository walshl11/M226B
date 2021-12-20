using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Classes
{
    public class Actor : Person
    {
        public new void Greet()
        {
            Console.WriteLine($"Hello I am a Actor, my name is {GetName()}");
        }

        public new int GetAge()
        {
            return base.GetAge() + 5;
        }

        public Actor(string firstname, string surname, int age) : base(firstname, surname, age)
        {

        }
    }
}
