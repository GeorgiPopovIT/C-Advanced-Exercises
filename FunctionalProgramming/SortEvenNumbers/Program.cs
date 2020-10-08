using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ")
              .Select(int.Parse).Where(i => i % 2 == 0).OrderBy(i => i).ToArray();
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
