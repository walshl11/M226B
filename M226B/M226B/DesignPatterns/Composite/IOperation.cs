namespace DesignPatterns.Composite
{
    /// <summary>
    /// This defines the base functionality for both a single Operation and multiple
    /// operations.
    /// </summary>
    public interface IOperation
    {
        public double GetValue();

        public double Add(IOperation op);

        public double Subtract(IOperation op);

        public double Multiply(IOperation op);

        public double Divide(IOperation op);

        public void AddChild(IOperation op);
    }
}
