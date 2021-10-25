using Polymorphism.Classes;
using Polymorphism.Interfaces;
using System;
using System.Linq;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Customer customer = new Customer();
            SalesManager salesmanager = new SalesManager();
            person.Children.ToList().Add(salesmanager);
            person.Parent = salesmanager;


            IManageableEntity location = new Person();
            IManageableEntity lol = new SalesManager();

            Console.ReadKey();

            Location location1 = new Location();
            ILocation location2 = new Location();


            Person person1 = new Person();
            Person person45 = new Customer();
            Customer person3 = new Customer();
        }
    }
}
