using dotnet_improvement.Core.Enums;
using System;

namespace dotnet_improvement.Presentation.Testers
{
    public static class EnumTester
    {
        public static void TestEnum()
        {
            Console.WriteLine(Status.Pending); // Pending
            Console.WriteLine((int)Status.Done); // 0
        }
    }
}