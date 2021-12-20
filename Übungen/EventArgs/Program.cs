using EventArgs.Classes;
using EventArgs.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventArgs
{
    class Program
    {
        public static string LogFileName { get; set; } = @"C:\Users\walshl11\Documents\M226B\GitRepository\Übungen\EventArgs\log\log.json";
        static void Main(string[] args)
        {
            IEnumerable<Car> allCars = new List<Car>();

            for (int i = 0; i < 6; i++)
            {
                Car newCar = new Car($"Car{i}", "Tesla", i * 5);

                allCars = allCars.Append(newCar).ToList();
            }

            foreach (Car item in allCars.Where(x => x.Force >= 10))
            {
                item.Crash += OnCarCrash;
                item.CrashCar();
            }

            Log.LogToFile(allCars.ToList(), LogFileName);
        }

        static void OnCarCrash(object sender, CrashEventArgs args)
        {
            Car senderCar = (Car)sender;

            Console.WriteLine($"Car {senderCar?.Name} crashed:");
            Console.WriteLine($"With a force of {senderCar?.Force} N");
        }
    }
}
