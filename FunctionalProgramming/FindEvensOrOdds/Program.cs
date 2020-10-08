using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string filter = Console.ReadLine();

            Func<int, bool> checker = x =>
            {
                if (filter == "odd")
                {
                    return x % 2 != 0;
                }
                else if (filter == "even")
                {
                    return x % 2 == 0;
                }
                else
                {
                    return false;
                }
            };
            List<int> list = new List<int>();
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (checker(i))
                {
                    list.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
