namespace DesignPatterns.Composite
{
    /// <summary>
    /// This defines the base functionality for both a single Operation and multiple
    /// operations.
    /// </summary>
    public abstract class OperationBase
    {
        public abstract double GetValue();

        public abstract double Add(OperationBase op);

        public abstract double Subtract(OperationBase op);

        public abstract double Multiply(OperationBase op);

        public abstract double Divide(OperationBase op);

        public abstract void AddChild(OperationBase op);
    }
}
