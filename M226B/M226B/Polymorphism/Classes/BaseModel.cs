using Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Classes
{
    public abstract class BaseModel : IBaseModel
    {
        public int Id { get; set; }

        public string Text { get; set; }
    }
}
