using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Interfaces
{
    public  interface ILocation : IManageableEntity, IStatisticEntity
    {
        public string Name { get; set; }

        public void GetAvailableVehicles();
        
        public void GetFreeSalesManager();

        public void Visit();
    }
}
