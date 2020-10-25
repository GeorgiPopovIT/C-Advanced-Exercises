using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(BinarySearch(array, n, 0, array.Length - 1));
        }

        private static int BinarySearch(int[] array, int number, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }
            int middle = (start + end) / 2;

            if (number < array[middle])
            {
                return BinarySearch(array, number, start, middle - 1);
            }
            else if (number > array[middle])
            {
                return BinarySearch(array, number, middle + 1, end);
            }
            else
            {
                return middle;
            }
        }
    }
}
