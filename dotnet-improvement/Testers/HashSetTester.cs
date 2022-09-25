using System;
using System.Collections.Generic;

namespace dotnet_improvement.Presentation.Testers
{
    public static class HashSetTester
    {
        public static void TestHashSet()
        {
            // Duplicate values will be removed from HashSet
            HashSet<int> hashSet = new HashSet<int>() { 1, 1, 1, 2, 2, 3 };
            foreach (int value in hashSet)
            {
                Console.Write(value);
            }
        }
    }
}