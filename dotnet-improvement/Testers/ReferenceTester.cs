
using dotnet_improvement.Core.Domain.DTOs;
using System;

namespace dotnet_improvement.Presentation.Testers
{
    public static class ReferenceTester
    {
        public static void TestStringReferences()
        {
            string str1 = "Hi";
            string str2 = "Hi";

            // not assigned by reference because create new instance with the same value:
            string str3 = String.Copy(str1);

            Console.WriteLine(Object.ReferenceEquals(str1, str2));
            Console.WriteLine(Object.ReferenceEquals(str1, str3));
        }
    }
}