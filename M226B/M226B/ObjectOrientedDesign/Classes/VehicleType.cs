using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesign.Interfaces;

namespace ObjectOrientedDesign.Classes
{
    public class VehicleType : IVehicleType
    {
        private string _name;

        public VehicleType(string name)
        {
            _name = name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}