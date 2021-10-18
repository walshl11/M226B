using Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Classes
{
    public class CarType : BaseModel, ICarType
    {
        public Type GetCarType { get; set; }

        public string Name { get; set; }
    }
}
