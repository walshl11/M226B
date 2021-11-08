using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism.Interfaces;

namespace Polymorphism.Classes
{
    public class CarType : BaseModel, ICarType
    {
        public Type GetCarType { get; set; }

        public string Name { get; set; }
    }
}
