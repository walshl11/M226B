using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Composite;

namespace Testing
{
    public class OperationStub : IOperation
    {
        private double _value;

        public OperationStub()
        {
            _value = 10;
        }

        public double GetValue()
        {
            return _value;
        }

        public double Add(IOperation op)
        {
            return 15;
        }

        public double Subtract(IOperation op)
        {
            return 5;
        }

        public double Multiply(IOperation op)
        {
            return 100;
        }

        public double Divide(IOperation op)
        {
            return 2;
        }

        public void AddChild(IOperation op)
        {
            throw new InvalidOperationException();
        }
    }
}
