using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Classes
{
    public class Car : Vehicle
    {
        public Type Type { get; set; }

        public Car() : base()
        {
            Type = typeof(Car);
        }

        public Car(Type type) : base()
        {
            Type = type;
        }

        public string GetTypeName()
        {
            return Type.Name;
        }
    }
}
