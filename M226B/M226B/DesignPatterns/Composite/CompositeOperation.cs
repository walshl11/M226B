using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class CompositeOperation : IOperation
    {
        private double _value;

        private List<IOperation> _subOperations;

        public CompositeOperation(double value)
        {
            _value = value;
            _subOperations = new List<IOperation>();
        }

        public double GetValue()
        {
            double totalValue = _value;

            checked
            {
                foreach (IOperation subOperation in _subOperations)
                    totalValue += subOperation.GetValue();
            }

            return totalValue;
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
            _subOperations.Add(op);
        }
    }
}
