using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize
{
    [Serializable]
    public class Client
    {
        private int clientNumber;
        private string firstname;
        private string surName;
        private double factor;
        [NonSerialized]
        int regionNumber;

        public Client(int pClientNumber, string pFirstName, string pSurName, double pFactor,
                        int pRegionNumber)
        {
            clientNumber = pClientNumber;
            firstname = pFirstName;
            surName = pSurName;
            factor = pFactor;
            regionNumber = pRegionNumber;
        }

        public void printClient()
        {
            Console.WriteLine($"Client number: {clientNumber}");
            Console.WriteLine($"First Name: {firstname}");
            Console.WriteLine($"Surname: {surName}");
            Console.WriteLine($"Factor: {factor}");
            Console.WriteLine($"Region Number: {regionNumber}");
        }
    }
}
