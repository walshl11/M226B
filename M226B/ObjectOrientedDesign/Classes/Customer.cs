using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesign.Interfaces;

namespace ObjectOrientedDesign.Classes
{
    public class Customer : PersonBase
    {
        public Customer(string name) : base(name)
        {
        }

        public void RentVehicle(IVehicle vehicle)
        {
            vehicle.Rent(this);
        }

        public void ReturnVehicle(IVehicle vehicle)
        {
            vehicle.ReturnVehicle();
        }
    }
}
