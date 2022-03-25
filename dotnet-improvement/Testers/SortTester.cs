using dotnet_improvement.Helpers;

namespace dotnet_improvement.Testers
{
    public static class SortTester
    {
        public static void StartBubbleSortProcess()
        {
            int[] array = { 8, 6, 4, 2, 9, 3, 1, 5, 7 };
            array.BubbleSort();
            var sortedArray = array;
        }
    }
}
