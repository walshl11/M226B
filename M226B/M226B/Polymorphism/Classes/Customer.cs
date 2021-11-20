using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Classes
{
    public class Customer: Person
    {
        public IEnumerable<int> IdsOfSoldArticles { get; set; }

        public Customer() : base()
        {
            IdsOfSoldArticles = new List<int>();
        }

        public override void PrintInfos()
        {
            base.PrintInfos();

            Console.WriteLine("Ids of Sold Articles:");
            foreach (int id in IdsOfSoldArticles)
                Console.WriteLine($"\t{id}");
        }
    }
}
