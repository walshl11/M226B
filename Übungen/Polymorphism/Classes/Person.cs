using Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Classes
{
    public class Person : BaseModel, IManageableEntity
    {
        public object Parent { get; set; }

        public IEnumerable<object> Children { get; set; }

        public string Name { get; set; }

        private object location;

        public Person()
        {
            Children = new List<object>();
            location = "";
        }

        public void AddChild(object child)
        {
            Children = Children.Append(child);
        }


        public virtual void PrintInfos()
        {
            Console.WriteLine($"Parent type: \t{Parent.GetType().Name}");
            Console.WriteLine($"Children: \t {Children.GetType().Name}");
            Console.WriteLine($"Name: \t {Name}");
            Console.WriteLine($"Location: \t {location}");
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public virtual void SetParent(object parent)
        {
            Parent = parent;
        }
    }
}
