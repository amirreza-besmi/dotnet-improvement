using System;
using System.Collections;

namespace dotnet_improvement.Presentation.Testers
{
    public static class GeneralTester
    {

        public static void TestIList()
        {
            IList nums = null;
            var x = nums?[0];
            Console.WriteLine(nums?[0]);
        }

        public static void TestConversion()
        {
            Console.WriteLine(Convert.ToInt32('A'));
            Console.WriteLine(Convert.ToInt32("A"));
        }
    }
}