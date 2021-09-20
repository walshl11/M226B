using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Users\walshl11\Documents\M226B\byteArray.bin";

            byte[] arraywrite = { 200, 201, 202, 203, 204, 205, 206, 207 };
            byte[] arrayread = new byte[arraywrite.Length];

            FileStream fs = new FileStream(filename, FileMode.CreateNew);

            fs.Write(arraywrite, 0, arraywrite.Length);

            fs.Position = 0;
            fs.Read(arrayread, 0, arrayread.Length);

            for (int count = 0; count < arrayread.Length; count++)
            {
                Console.WriteLine(arrayread[count] + ", ");
            }

            fs.Close();

            File.Delete(filename);
        }
    }
}
