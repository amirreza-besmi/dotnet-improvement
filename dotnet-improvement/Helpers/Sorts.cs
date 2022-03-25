using System;
using System.Collections.Generic;

namespace dotnet_improvement.Helpers
{
    public static class Sorts
    {
        /// <summary>
        /// Sorts the given list & compare func with bubble sort algorithm.
        /// </summary>
        public static void BubbleSort<T>(this List<T> items, Func<T, T, bool> compareFunc)
        {
            bool orderChanged; // order of array's items changed?
            int lastItemIndex = items.Count - 1;

            do
            {
                orderChanged = false;
                for (int index = 0; index < lastItemIndex; index++)
                {
                    if (compareFunc(items[index], items[index + 1]))
                    {
                        T currentItem = items[index];
                        items[index] = items[index + 1];
                        items[index + 1] = currentItem;
                        orderChanged = true;
                    }
                }
            } while (orderChanged); // because if any order change cause traverse array again for sorting
        }

        /// <summary>
        /// Sorts the given array with bubble sort algorithm.
        /// </summary>
        public static void BubbleSort(this int[] array)
        {
            bool orderChanged; // order of array's items changed?
            int lastItemIndex = array.Length - 1;

            do
            {
                orderChanged = false;
                for (int index = 0; index < lastItemIndex; index++)
                {
                    if (array[index] > array[index + 1])
                    {
                        int currentItem = array[index];
                        array[index] = array[index + 1];
                        array[index + 1] = currentItem;
                        orderChanged = true;
                    }
                }
            } while (orderChanged); // because if any order change cause traverse array again for sorting
        }
    }
}
