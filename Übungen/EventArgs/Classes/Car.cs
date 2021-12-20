using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventArgs.Classes
{
    public class Car : CarCrash
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public Car(string name,string manufacturer, float force) : base(force)
        {
            Name = name;
            Manufacturer = manufacturer;
        }
    }
}
