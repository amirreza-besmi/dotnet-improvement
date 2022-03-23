
using System;
using static dotnet_improvement.Configs.Delegates;

namespace dotnet_improvement.Helpers
{
    public static class CoreHelper
    {
        public static void StartDelegateProcess()
        {
            GetTextDelegate getGreetingTextDelegate = new GetTextDelegate(GetGreetingText);
            string greetingText = getGreetingTextDelegate.Invoke();
            Console.WriteLine($"Result: {greetingText}");

            CalcNumberDelegate calcNumberDelegate = Calculator.Divide;
            double calcResult = calcNumberDelegate(8, 2);
            Console.WriteLine($"Calculation Result: {calcResult}");

            CalcNumberDelegate[] operations =
            {
                Calculator.Add,
                Calculator.Subtract,
                Calculator.Multiply,
                Calculator.Divide
            };

            for (int operationIndex = 0; operationIndex < operations.Length; operationIndex++)
            {
                Console.WriteLine($"Run Operation {operationIndex}");
                RunCalculationMethod(operations[operationIndex], 100, 5);
            }
        }

        public static void RunCalculationMethod(CalcNumberDelegate calcNumberDelegate, int firstNumber, int secondNumber)
        {
            double result = calcNumberDelegate.Invoke(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber}, {secondNumber} = {result}");
        }

        public static string GetGreetingText()
        {
            return "Hello, Welcome!";
        }
    }
}
