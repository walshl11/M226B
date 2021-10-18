using Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Classes
{
    public class Vehicle : BaseModel, IManageableEntity
    {
        public object Parent { get; set; }
        public IEnumerable<object> Children { get; set; }

        public string Brand { get; set; }

        public string Name { get; set; }
        public string Text { get; set; }

        public Location Location { get; set; }

        public Vehicle() : base()
        {

        }

        public Vehicle(string name) : base()
        {
            Name = name;
        }

        public void AddChild(object child)
        {
            Children = Children.Append(child);
        }

        public void Drive()
        {
            return;
        }

        public void SetParent(object parent)
        {
            Parent = parent;
        }

        public bool IsAvailable()
        {
            return false;
        }

        public void Reserve()
        {
            return;
        }

    }
}
