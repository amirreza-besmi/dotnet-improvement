using dotnet_improvement.Helpers;
using System;
using static dotnet_improvement.Configs.Delegates;

namespace dotnet_improvement.Testers
{
    public static class DelegateTester
    {
        public static void StartMultiCastDelegateProcess()
        {
            Action<int, int> action = AddAction;
            action += SumAction;

            action.Invoke(20, 5);
        }

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

        public static void StartFuncProcess()
        {
            Func<int, int, double>[] operations =
            {
                Calculator.Add,
                Calculator.Subtract,
                Calculator.Multiply,
                Calculator.Divide
            };

            for (int operationIndex = 0; operationIndex < operations.Length; operationIndex++)
            {
                Console.WriteLine($"Run Operation {operationIndex}");
                RunCalculationMethodByFunc(operations[operationIndex], 100, 5);
            }
        }

        public static void StartActionProcess()
        {
            RunCalculationMethodByAction(AddAction, 100, 2);
        }

        #region Private Methods

        private static void RunCalculationMethod(CalcNumberDelegate calcNumberDelegate, int firstNumber, int secondNumber)
        {
            double result = calcNumberDelegate.Invoke(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber}, {secondNumber} = {result}");
        }

        private static void RunCalculationMethodByFunc(Func<int, int, double> calcNumberFunc,
                                                      int firstNumber, int secondNumber)
        {
            double result = calcNumberFunc.Invoke(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber}, {secondNumber} = {result}");
        }

        private static void RunCalculationMethodByAction(Action<int, int> calcNumberAction,
                                                         int firstNumber, int secondNumber)
        {
            calcNumberAction.Invoke(firstNumber, secondNumber);
        }

        private static void SumAction(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Sum Action Result = {firstNumber + secondNumber}");
        }

        private static void AddAction(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Add Action Result = {firstNumber + secondNumber}");
        }

        private static string GetGreetingText()
        {
            return "Hello, Welcome!";
        }

        #endregion
    }
}
