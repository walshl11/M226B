using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Interfaces
{
    public interface ILocation : IManageableEntity
    {
        public string Name { get; set; }

        [Obsolete]
        public void GetAvailableVehicle();

        [Obsolete]
        public void GetFreeSalesMan();

        public void Visit();
    }
}
