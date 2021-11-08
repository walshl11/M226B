using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MemoryStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"C:\Users\reglim\source\repos\Schule\01-M226B\M226B\MemoryStream\ArrayDump.bin";

            const int ArrayLength = 20;
            byte[] WriteArray = new byte[ArrayLength];
            byte[] ReadArray = new byte[ArrayLength];

            new Random().NextBytes(WriteArray);

            FileStream fstr = new(Path, FileMode.Create);

            fstr.Write(WriteArray);

            fstr.Position = 0;
            fstr.Read(ReadArray, 0, ArrayLength);

            for (int i = 0; i < ArrayLength; i++)
            {
                if(i is not ArrayLength - 1)
                    Console.Write(ReadArray[i]+ ", ");
                else
                    Console.Write(ReadArray[i]);
            }

            fstr.Close();
            File.Delete(Path);

            Console.ReadKey();
        }
    }
}
