using Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Classes
{
    public class Location : BaseModel, ILocation
    {
        public string Name { get; set; }
        public object Parent { get; set; }
        public IEnumerable<object> Children { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        public IEnumerable<Vehicle> Vehicles { get; set; }

        private IEnumerable<Customer> _currentVisitors;

        public Location()
        {
            Parent = new object();
            Children = new List<object>();
            Employees = new List<Employee>();
            Vehicles = new List<Vehicle>();
            _currentVisitors = new List<Customer>();
        }

        public void AddChild(object child)
        {
            Children = Children.Append(child);
        }

        public void AvailableCars()
        {
            return;
        }

        public void GetAvailableVehicle()
        {
            return;
        }

        public void GetFreeSalesMan()
        {
            return;
        }

        public void SetParent(object parent)
        {
            Parent = parent;
        }

        public void Visit()
        {
            return;
        }

        public void PrintStatistics()
        {
            return;
        }
    }
}
