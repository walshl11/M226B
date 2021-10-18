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
            LoadingWeight = 500;
        }

        public Truck(double loadingweight) : base()
        {
            LoadingWeight = loadingweight;
        }
    }
}
