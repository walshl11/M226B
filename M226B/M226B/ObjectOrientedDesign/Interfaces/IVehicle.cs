using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Interfaces
{
    public interface IVehicle
    {
        IVehicleType GetType();

        void SetType(IVehicleType type);

        void Rent(IPerson tenant);

        void ReturnVehicle();

        IEnumerable<IPerson> GetPastTenants();

        void PrintInfo();
    }
}
