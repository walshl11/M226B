using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLogging.Classes
{
    [Serializable]
    public abstract class LogBase
    {
        public DateTime LoggedOn { get; protected set; }

        public LogLevel LogLevel { get; protected set; }

        public string Source { get; protected set; }

        public string Content { get; protected set; }

        protected LogBase(LogLevel logLevel, string source, string content)
        {
            LoggedOn = DateTime.Now;
            LogLevel = logLevel;
            Source = source;
            Content = content;
        }

        public virtual void PrintLog()
        {
            Console.WriteLine($"Log of {LoggedOn}:");
            Console.WriteLine($"\tLevel:\t\t{LogLevel}");
            Console.WriteLine($"\tSource:\t\t{Source}");
            Console.WriteLine($"\tContent:\t{Content}");
        }
    }
}
