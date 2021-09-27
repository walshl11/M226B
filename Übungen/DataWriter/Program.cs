using System;
using System.IO;
using System.Text;

namespace DataWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Users\walshl11\Documents\M226B\textValues.txt";

            FileStream fs = new FileStream(filename, FileMode.CreateNew);
            fs.Close();

            StreamWriter sw = new StreamWriter(filename);

            sw.WriteLine(1234);
            sw.WriteLine(5.678);
            sw.WriteLine("Hello friends; Special symbols: ¤ Ã¶ Ã¼");
            sw.Close();

            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read), Encoding.Default);

            Console.WriteLine("Content of file: \"{0}\":", ((FileStream)sr.BaseStream).Name);

            for (int count = 0; sr.Peek() >= 0; count++) 
            { 
                Console.WriteLine("{0}:\t{1}", count, sr.ReadLine()); 
            }
            sr.Close();

        }
    }
}
