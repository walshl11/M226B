using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using JsonLogging.Classes;

namespace JsonLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            //as JSON
            string jsonLogFileName = $"Log-Json-{DateTime.Now:yyyy-MM-dd-hh-mm-ss-fff}.log";
            string jsonLogFilePath = @$"C:\Users\reglim\source\repos\Schule\01-M226B\M226B\JsonLogging\{jsonLogFileName}";


            LogFile jsonLogFile = new(jsonLogFilePath, jsonLogFileName);
            Log jsonLog = new(LogLevel.Info, "Program.Main", "JsonLogging was started with JSON", jsonLogFile);

            Console.WriteLine("Original Json Log:");
            jsonLog.PrintLog();

            StreamWriter sw = new StreamWriter(jsonLogFilePath, false, Encoding.UTF8);

            sw.Write(JsonSerializer.Serialize(jsonLog));
            sw.Close();

            StreamReader sr = new StreamReader(jsonLogFilePath, Encoding.UTF8);
            
            Log readJsonLog = JsonSerializer.Deserialize<Log>(sr.ReadToEnd());
            sr.Close();

            Console.WriteLine("Read Json Log:");
            readJsonLog?.PrintLog();

            //as binary
            string binaryLogFileName = $"Log-Bin-{DateTime.Now:yyyy-MM-dd-hh-mm-ss-fff}.log";
            string binaryLogFilePath = @$"C:\Users\reglim\source\repos\Schule\01-M226B\M226B\JsonLogging\{binaryLogFileName}";


            LogFile binaryLogFile = new(binaryLogFilePath, binaryLogFileName);
            Log binaryLog = new(LogLevel.Info, "Program.Main", "JsonLogging was started with binary", binaryLogFile);

            Console.WriteLine("Original Binary Log:");
            binaryLog.PrintLog();

            IFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new(binaryLogFilePath, FileMode.Create);

            //these methods should not be used. Just for demonstration
            formatter.Serialize(fileStream, binaryLog);
            fileStream.Position = 0;
            Log binaryReadLog = (Log) formatter.Deserialize(fileStream);

            Console.WriteLine("Read Binary Log");
            binaryReadLog?.PrintLog();

            Console.ReadKey();
        }
    }
}
