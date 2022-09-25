
using dotnet_improvement.Core.Domain.DTOs;
using System;

namespace dotnet_improvement.Presentation.Testers
{
    public static class PrivateConstructorTester
    {
        public static void TestPrivateConstructor()
        {
            // If you uncomment the following statement, it will generate
            // an error because the constructor is inaccessible:
            // Counter aCounter = new Counter();   // Error

            Counter.currentCount = 50;
            Counter.IncrementCount();
            Console.WriteLine(Counter.currentCount);
        }
    }
}