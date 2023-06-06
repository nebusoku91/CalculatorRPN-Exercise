
// The NumberStack class provides a stack data structure to store numbers.
// It supports operations such as pushing values onto the stack, popping values
// from the stack, retrieving the top value without removing it, clearing the stack,
// and generating a string representation of the stack.

using CalculatorRPN_Exercise.Interfaces;
using System.Text;

namespace CalculatorRPN_Exercise.Data
{
    public class NumberStack : INumberStack
    {
        public double[] stackData { get; set; }
        public int currentSizeOfStack { get; set; }

        public NumberStack(double[] inputStackData, int inputCurrentSizeOfStack)
        {
            stackData = inputStackData;
            currentSizeOfStack = inputCurrentSizeOfStack;
        }

        public void ErrorMessage()
        {
            Console.WriteLine("Stack is empty, returning 0");
        }

        public void Push(double value)
        {
            stackData[currentSizeOfStack++] = value;
        }

        public double Pop()
        {
            if (currentSizeOfStack > 0)
            {
                return stackData[--currentSizeOfStack];
            }
            else
            {
                ErrorMessage();
                return 0;
            }
        }

        public double Peek()
        {
            if (currentSizeOfStack > 0)
            {
                return stackData[currentSizeOfStack - 1];
            }
            else
            {
                ErrorMessage();
                return 0;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append('[');
            for (int i = currentSizeOfStack - 1; ; i--)
            {
                builder.Append(stackData[i]);
                if (i == 0)
                    return builder.Append(']').ToString();
                builder.Append(", ");
            }
        }

        public void ClearStack()
        {
            currentSizeOfStack = 0;
        }
    }
}


