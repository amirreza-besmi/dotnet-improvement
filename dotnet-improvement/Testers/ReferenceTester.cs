
using dotnet_improvement.Core.Domain.DTOs;
using System;

namespace dotnet_improvement.Presentation.Testers
{
    public static class ReferenceTester
    {
        public static void TestStringReferences()
        {
            string str1 = "Hi";
            // not assigned by reference because create new instance with the same value:
            string str2 = String.Copy(str1);

            Console.WriteLine(Object.ReferenceEquals(str1, str2));
        }
    }
}