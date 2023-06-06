
// By appending "Controller" to the class name,
// it indicates that this class serves as a controller or coordinator for the
// calculator functionality. It implies that it may handle user input,
// manage the stack, and orchestrate the interactions between different
// components of the calculator.

using CalculatorRPN_Exercise.Interfaces;
using CalculatorRPN_Exercise.UI;

namespace CalculatorRPN_Exercise.Controllers
{
    public class CalculatorController : ICalculatorController
    {
        private readonly INumberStack stack;
        private readonly UserInterface userInterface;

        public CalculatorController(INumberStack stack, UserInterface userInterface)
        {
            this.stack = stack;
            this.userInterface = userInterface;
        }

        public void Run()
        {
            userInterface.WelcomeMessage();
            userInterface.Menu();
        }
    }
}


