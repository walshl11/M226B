using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events.EventArgs;

namespace Events.Interfaces
{
    public interface IExplosive
    {
        event EventHandler<ExplosionEventArgs> Explosion;
    }
}
