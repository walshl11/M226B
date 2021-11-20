using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLogging.Classes
{
    [Serializable]
    public class Log : LogBase
    {
        public  LogFile LoggedInFile { get; private set; }

        public Log(LogLevel logLevel, string source, string content, LogFile loggedInFile) : base(logLevel, source, content)
        {
            LoggedInFile = loggedInFile;
        }

        public override void PrintLog()
        {
            base.PrintLog();
            Console.WriteLine($"\tLogged In :\t{LoggedInFile.FileName}\n");
        }
    }
}
