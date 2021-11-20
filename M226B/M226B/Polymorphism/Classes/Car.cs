using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Classes
{
    public class Car : Vehicle
    {
        public CarType Type { get; set; }

        public Car() : base()
        {
            CarType defaultType = new()
            {
                Name = "Default Car Type",
                Text = "Tesla"
            };

            Type = defaultType;
        }

        public Car(string name) : base(name)
        {
            CarType defaultType = new()
            {
                Name = "Default Car Type",
                Text = "Tesla"
            };

            Type = defaultType;
        }

        public string GetTypeName()
        {
            return Type.Name;
        }
    }
}
