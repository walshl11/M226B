using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism.Interfaces;

namespace Polymorphism.Classes
{
    public class Location : BaseModel, ILocation
    {
        public object Parent { get; set; }

        public IEnumerable<object> Children { get; set; }

        public string Name { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        public IEnumerable<Vehicle> Vehicles { get; set; }

        private IEnumerable<Customer> _currentVisitors;

        public Location()
        {
            Parent = new();
            Children = new List<object>();
            Name = "";
            Employees = new List<Employee>();
            Vehicles = new List<Vehicle>();
            _currentVisitors = new List<Customer>();

        }
        
        public void AddChild(object child)
        {
            return;
        }

        public void SetParent(object parent)
        {
            return;
        }

        public void GetAvailableVehicles()
        {
            return;
        }

        public void AvailableCars()
        {
            return;
        }

        public void GetFreeSalesManager()
        {
            return;
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
