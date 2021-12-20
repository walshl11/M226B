using EventArgs.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventArgs.Interfaces
{
    public interface ICrash
    {
        event EventHandler<CrashEventArgs> Crash;
    }
}
