using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism.Interfaces;

namespace Polymorphism.Classes
{
    public abstract class Vehicle : BaseModel, IManageableEntity, IBookableEntity
    {
        public object Parent { get; set; }

        public IEnumerable<object> Children { get; set; }
       
        public string Brand { get; set; }

        public string Name { get; set; }

        public new string Text { get; set; }

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
            return;
        }

        public void SetParent(object parent)
        {
            return;
        }

        public void Drive()
        {
            return;
        }

        public bool IsAvailable()
        {
            return true;
        }

        public void Reserve()
        {
            return;
        }
    }
}
