
// The UserInterface class represents the user interface for the RPN calculator.
// It provides methods for displaying messages, handling user input,
// and coordinating interactions with the RPN calculator.
// The class utilizes the INumberStack interface for managing the stack used by the calculator.
// It presents a command menu to the user, reads input from the console,
// and performs calculator operations based on the user's commands.

using CalculatorRPN_Exercise.Interfaces;
using CalculatorRPN_Exercise.Services;
using System;

namespace CalculatorRPN_Exercise.UI
{
    public class UserInterface
    {
        private readonly INumberStack stack;

        public UserInterface(INumberStack stack)
        {
            this.stack = stack;
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome! This is an RPN Calculator!");
        }

        public bool TryParseInput(string input, out double value)
        {
            if (double.TryParse(input, out value))
            {
                return true;
            }
            return false;
        }

        public void CommandMenu()
        {
            try
            {
                if (stack.currentSizeOfStack == 0)
                {
                    Console.WriteLine("Commands: q c + - * / number");
                    Console.WriteLine("q = quit, c = clear numbers");
                    Console.WriteLine("Enter Value:");
                }
                else
                {
                    Console.WriteLine(stack.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }

        }

        public string ReadInput()
        {
            try
            {
                string input = Console.ReadLine().Trim();
                if (input == "")
                {
                    input = " ";
                }
                return input;
            }
            catch
            {
                return "";
            }
        }

        public void Menu()
        {
            Calculator calculator = new Calculator(stack, this);

            while (true)
            {
                CommandMenu();

                string commandInput = ReadInput();

                if (commandInput == "q")
                {
                    break;
                }

                calculator.PerformOperation(commandInput);
            }
        }
    }
}



