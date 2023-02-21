
using System;

namespace dotnet_improvement.Presentation.Testers
{
    public static class ExceptionTester
    {
        public static void TestAssigning()
        {
            int i = 1, j = 2, x = 3; // with var we have compile error
            Console.WriteLine(x = i * j);
        }

        public static void TestExceptions()
        {
            int[,] arr1 = new int[5, 2]; // ok
            int[][,] arr2 = new int[5][,]; // ok

            int[] arr = { 1, 2, 3, 4, 5 };

            try
            {
                Console.WriteLine(arr[10]);
            }
            /*catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index Error");
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Null Reference Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }*/
            finally
            {
                Console.WriteLine("finally occured!");
            }
        }
    }
}