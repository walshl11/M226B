using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class PrimitiveOperation : IOperation
    {
        private double _value;

        public PrimitiveOperation(double value)
        {
            _value = value;
        }

        public double GetValue()
        {
            return _value;
        }

        public double Add(IOperation op)
        {
            checked
            {
                return _value + op.GetValue();
            }
        }

        public double Subtract(IOperation op)
        {
            checked
            {
                return _value - op.GetValue();
            }
        }

        public double Multiply(IOperation op)
        {
            checked
            {
                return _value * op.GetValue();
            }
        }

        public double Divide(IOperation op)
        {
            checked
            {
                return _value / op.GetValue();
            }
        }

        public void AddChild(IOperation op)
        {
            throw new NotImplementedException("Primitive Operation does not support this Method.");
        }
    }
}
