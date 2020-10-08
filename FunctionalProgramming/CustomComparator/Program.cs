using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var nums = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();
            Func<int, List<int>, bool> func = DeviderInfo;
            List<int> numbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (func(i,nums))
                {
                    numbers.Add(i);
                }
            }
            Console.WriteLine(String.Join(" ",numbers));
            
        }
        static bool DeviderInfo(int n, List<int> deviders)
        {
            bool isTrue = true;
            foreach (var item in deviders)
            {
                if (n % item != 0)
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
    }
}
