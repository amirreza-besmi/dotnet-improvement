using System;

namespace dotnet_improvement.Presentation.Testers
{
    public static class ArrayTester
    {
        public static void TestArray()
        {
            int?[] arr = new int?[5];
            
            var x = arr[0];
            Console.WriteLine(arr[0]);
        }
    }
}