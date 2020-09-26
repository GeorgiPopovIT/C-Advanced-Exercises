using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                for (int j = 0; j < line.Length; j++)
                {
                    set.Add(line[j]);
                }
            }
            Console.WriteLine(String.Join(" ", set));
        }
    }
}
