using Polymorphism.Classes;
using Polymorphism.Interfaces;
using System;
using System.Linq;

namespace Polymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            Customer customer = new Customer();
            SalesManager salesmanager = new SalesManager();
            person.Children.ToList().Add(salesmanager);
            person.Parent = salesmanager;


            IManageableEntity personManageable = new Person();
            personManageable.AddChild(new object());
            IManageableEntity salesManager = new SalesManager();

            Console.ReadKey();

            Location location1 = new Location();
            ILocation location2 = new Location();
            location2.AddChild(new object());

            Person person1 = new Person();  
            Person person45 = new Customer();
            Customer parsed = (Customer)person45;
            Customer person3 = new Customer();
        }
    }
}