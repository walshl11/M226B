using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Classes
{
    public class Truck : Vehicle
    {
        public double LoadingWeight { get; set; }

        public Truck() : base()
        {
            LoadingWeight = 5000;
        }

        public Truck(string name) : base(name)
        {
            LoadingWeight = 5000;
        }
    }
}
