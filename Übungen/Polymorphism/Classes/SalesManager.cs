using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Classes
{
    public class SalesManager : Employee
    {
        private Customer _currentCustomer;

        public string SalesArea { get; set; }

        public SalesManager() : base()
        {
            SalesArea = "";
            _currentCustomer = new Customer();
        }

        public bool IsFree()
        {
            return false;
        }

        public void SetCustomer(Customer customer)
        {
            _currentCustomer = customer;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
