using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLogging.Classes
{
    [Serializable]
    public class LogFile
    {
        public string Path { get; private set; }

        public string FileName { get; private set; }

        public LogFile(string path, string fileName)
        {
            Path = path;
            FileName = fileName;
        }
    }
}
