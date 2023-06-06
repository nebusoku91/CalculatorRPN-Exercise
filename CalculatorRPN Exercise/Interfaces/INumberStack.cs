namespace CalculatorRPN_Exercise.Interfaces
{
    public interface INumberStack
    {
        double[] stackData { get; }
        int currentSizeOfStack { get; }

        public void ClearStack();
        public double Peek();
        public double Pop();
        public void Push(double value);
        public string ToString();
    }
}