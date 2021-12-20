using EventArgs.EventArgs;
using EventArgs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventArgs.Classes
{
    public class CarCrash : ICrash
    {
        public event EventHandler<CrashEventArgs>? Crash;

        public float Force { get; set; }

        public CarCrash(float force)
        {
            Force = force;
        }

        public void CrashCar()
        {
            OnCrash(new CrashEventArgs()
            {
                Force = Force
            });
        }

        public virtual void OnCrash(CrashEventArgs args)
        {
            Crash?.Invoke(this, args);
        }
    }
}
