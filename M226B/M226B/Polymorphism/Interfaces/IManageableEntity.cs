using System.Collections.Generic;
using System.Linq;

namespace Polymorphism.Interfaces
{
    public interface IManageableEntity
    {
        public object Parent { get; set; }

        public IEnumerable<object> Children { get; set; }

        public void AddChild(object child);

        public void SetParent(object parent);
    }
}