using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Classes
{
    public class Bomb : Explosive
    {
        public string Name { get; set; }

        public Bomb(string name, double megaTonnes) : base(megaTonnes)
        {
            Name = name;
        }
    }
}
