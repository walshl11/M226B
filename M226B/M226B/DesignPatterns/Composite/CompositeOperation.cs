using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class CompositeOperation : OperationBase
    {
        private double _value;

        private List<OperationBase> _subOperations;

        public CompositeOperation(double value)
        {
            _value = value;
            _subOperations = new List<OperationBase>();
        }

        public override double GetValue()
        {
            double totalValue = _value;

            checked
            {
                foreach (OperationBase subOperation in _subOperations)
                    totalValue += subOperation.GetValue();
            }

            return totalValue;
        }

        public override double Add(OperationBase op)
        {
            checked
            {
                return _value + op.GetValue();
            }
        }

        public override double Subtract(OperationBase op)
        {
            checked
            {
                return _value - op.GetValue();
            }
        }

        public override double Multiply(OperationBase op)
        {
            checked
            {
                return _value * op.GetValue();
            }
        }

        public override double Divide(OperationBase op)
        {
            checked
            {
                return _value / op.GetValue();
            }
        }

        public override void AddChild(OperationBase op)
        {
            _subOperations.Add(op);
        }
    }
}
