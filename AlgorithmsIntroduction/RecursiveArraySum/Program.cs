using System;
using System.Linq;

namespace RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(Sum(array, 0));
        }
        private static int Sum(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }
            return arr[index] + Sum(arr, index + 1);
        }
    }
}
