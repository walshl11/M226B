using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesign.Interfaces;

namespace ObjectOrientedDesign.Classes
{
    public class VehicleBase : IVehicle
    {
        public string Name { get; set; }
     
        private IVehicleType _type;

        private IPerson? _currentTenant;

        private IEnumerable<IPerson> _pastTenants;

        public VehicleBase(string name)
        {
            Name = name;
        }

        public IVehicleType GetVehicleType()
        {
            return _type;
        }

        public void SetType(IVehicleType type)
        {
            _type = type;
        }

        public void Rent(IPerson tenant)
        {
            if (_currentTenant is not null)
                throw new ArgumentException("Vehicle is already rented.");

            _currentTenant = tenant;
        }

        public void ReturnVehicle()
        {
            if(_currentTenant is null)
                return;

            _pastTenants = _pastTenants.Append(_currentTenant);
        }

        public IEnumerable<IPerson> GetPastTenants()
        {
            List<IPerson> pastTenantList = _pastTenants.ToList();
            if(_currentTenant is not null)
                pastTenantList.Add(_currentTenant);

            return pastTenantList;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Details for Vehicle {Name}");
            Console.WriteLine($"Type:\t{_type.GetName()}");
            Console.WriteLine($"Tenants:\t");
            if (_currentTenant is not null)
                Console.WriteLine($"\t{_currentTenant.GetName()}*");

            foreach (IPerson pastTenant in _pastTenants)
                Console.WriteLine($"\t{pastTenant.GetName()}");
        }
    }
}
