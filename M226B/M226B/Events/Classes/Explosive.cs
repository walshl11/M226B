using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events.EventArgs;
using Events.Interfaces;

namespace Events.Classes
{
    public class Explosive : IExplosive
    {
        public event EventHandler<ExplosionEventArgs>? Explosion;

        public double MegaTonnes { get; set; }

        public Explosive(double megaTonnes)
        {
            MegaTonnes = megaTonnes;
        }

        public void Detonate()
        {
            OnExplosion(new ExplosionEventArgs()
            {
                MT = MegaTonnes
            });
        }

        public virtual void OnExplosion(ExplosionEventArgs e)
        {
            Explosion?.Invoke(this, e);
        }
    }
}
