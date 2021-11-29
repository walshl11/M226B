using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class PrimitiveOperation : OperationBase
    {
        private double _value;

        public PrimitiveOperation(double value)
        {
            _value = value;
        }

        public override double GetValue()
        {
            return _value;
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
            throw new NotImplementedException("Primitive Operation does not support this Method.");
        }
    }
}
