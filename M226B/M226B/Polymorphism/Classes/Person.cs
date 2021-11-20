using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism.Interfaces;

namespace Polymorphism.Classes
{
    public class Person : BaseModel, IManageableEntity, IPerson
    {
        public object Parent { get; set; }
        
        public IEnumerable<object> Children { get; set; }

        public string Name { get; set; }

        private ILocation location;

        public Person()
        {
            Children = new List<object>();
            location = new Location();
        }

        public virtual void AddChild(object child)
        {
            Children = Children.Append(child);
        }
     
        public virtual void PrintInfos()
        {
            Console.WriteLine($"Parent Type: \t {Parent.GetType().Name}");
            Console.WriteLine($"Name: \t {Name}");
            Console.WriteLine($"Location: \t {location}");
        }

        public virtual void SetParent(object parent)
        {
            Parent = parent;
        }
    }
}
