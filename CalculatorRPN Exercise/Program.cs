using CalculatorRPN_Exercise.Controllers;
using CalculatorRPN_Exercise.Data;
using CalculatorRPN_Exercise.Interfaces;
using CalculatorRPN_Exercise.UI;

namespace CalculatorRPN
{
    class Program
    {
        static void Main(string[] args)
        {
            INumberStack stack = new NumberStack(new double[1000], 0);
            UserInterface userInterface = new UserInterface(stack);
            CalculatorController calculatorController = new CalculatorController(stack, userInterface);
            calculatorController.Run();
        }
    }

}
