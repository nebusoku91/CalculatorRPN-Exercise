
// The RPNCalculator class represents a Reverse Polish Notation (RPN) calculator.
// It performs mathematical operations based on the provided command inputs.
// The class utilizes the INumberStack interface to store and manipulate numbers in the stack.

using CalculatorRPN_Exercise.Interfaces;
using CalculatorRPN_Exercise.UI;

namespace CalculatorRPN_Exercise.Services
{
    public class Calculator
    {
        private readonly INumberStack stack;
        private readonly UserInterface userInterface;

        public Calculator(INumberStack stack, UserInterface userInterface)
        {
            this.stack = stack;
            this.userInterface = userInterface;
        }

        public void PerformOperation(string commandInput)
        {
            if (userInterface.TryParseInput(commandInput, out double inputValue))
            {
                stack.Push(inputValue);
            }
            else
            {
                switch (commandInput)
                {
                    case "+":
                        stack.Push(stack.Pop() + stack.Pop());
                        break;
                    case "*":
                        stack.Push(stack.Pop() * stack.Pop());
                        break;
                    case "-":
                        double valueToSubtract = stack.Pop();
                        stack.Push(stack.Pop() - valueToSubtract);
                        break;
                    case "/":
                        double valueToDivide = stack.Pop();
                        stack.Push(stack.Pop() / valueToDivide);
                        break;
                    case "c":
                        stack.ClearStack();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input.");
                        break;
                }
            }
        }
    }
}


