using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialize
{
    class Program
    {
        static string filename = @"C:\Users\walshl11\Documents\M226B\clientfile.bin";
        static void Main(string[] args)
        {
            #region First Example
            Client[] clients = new Client[2];
            clients[0] = new Client(1, "Joe", "Mama", 1.234, 6300);
            clients[1] = new Client(2, "Tina", "Turner", 4.5, 8300);

            Console.WriteLine("Saved Client;\n");
            foreach (Client count in clients)
            {
                count.printClient();
                Console.WriteLine();
            }

            FileStream fs = new FileStream(filename, FileMode.Create);
            IFormatter bf = new BinaryFormatter();

            // Writes an Array of objects to a binary file
            bf.Serialize(fs, clients);

            fs.Position = 0;
            Console.WriteLine("\n\nReconstructed Clients:\n");

            // Reads an array of object from a binary file
            Client[] recClients = (Client[])bf.Deserialize(fs);

            foreach (Client count in recClients)
            {
                count.printClient();
                Console.WriteLine();
            }
            fs.Close();
            #endregion

            #region Second Example

            //List<Client> list1 = new List<Client>(); 
            //list1.Add(new Client(1, "Joe", "Hanson", 1.234, 6300)); 
            //list1.Add(new Client(2, "Tina", "Turner", 4.5, 8300));

            //Console.WriteLine("Saved Clients;\n");
            //foreach (Client count in list1)
            //{
            //    count.printClient();
            //    Console.WriteLine();
            //}

            //FileStream fs = new FileStream(filename, FileMode.Create); 
            //IFormatter bf = new BinaryFormatter();   

            //// Writes a list of objects to a binary file
            //bf.Serialize(fs, list1);   

            //fs.Position = 0; 
            //Console.WriteLine("\n\nReconstructed Clients:\n"); 

            //// Reads a list of objects from a binary file
            //List<Client> recList = (List<Client>)bf.Deserialize(fs);

            //foreach (Client count in recList)       
            //{         
            //    count.printClient(); 
            //    Console.WriteLine();       
            //}       

            //fs.Close(); 


            #endregion

            #region Third Example

            //ObservableCollection<Client> oclist1 = new ObservableCollection<Client>(); 
            //oclist1.Add(new Client(1, "Joe", "Hanson", 1.234, 6300)); 
            //oclist1.Add(new Client(2, "Tina", "Turner", 4.5, 8300)); 
            //Console.WriteLine("Safed Client;\n"); 
            //foreach (Client count in oclist1) 
            //{ 
            //    count.printClient(); 
            //    Console.WriteLine(); 
            //}

            //FileStream fs = new FileStream(filename, FileMode.Create); 
            //IFormatter bf = new BinaryFormatter();

            //// Writes anObservableCollection of objects to a binary file
            //bf.Serialize(fs, oclist1);

            //fs.Position = 0; 
            //Console.WriteLine("\n\nReconstructed Clients:\n"); 

            //// Reads an ObservableCollection of objects from a binary file
            //ObservableCollection<Client> recOcList =         
            //    (ObservableCollection<Client>)bf.Deserialize(fs); 

            //foreach (Client count in recOcList)       
            //{         
            //    count.printClient(); 
            //    Console.WriteLine();       
            //}       
            //fs.Close(); 

            #endregion
        }
    }
}
