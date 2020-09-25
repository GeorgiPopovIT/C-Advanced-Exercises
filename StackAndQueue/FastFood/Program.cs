using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>();
            Console.WriteLine(arr.Max());
            if (arr.Sum() <= num)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                int sum = arr.Sum();
                for (int i = arr.Length - 1; i > 0; i--)
                {

                    if (sum >= num)
                    {
                        stack.Push(arr[i]);
                        sum -= arr[i];
                    }
                    else
                    {
                        Console.WriteLine($"Orders left: {string.Join(" ", stack)}");
                        return;
                    }
                }
            }
        }
    }
}
