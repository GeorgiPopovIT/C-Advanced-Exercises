using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split()
                    .ToArray();
                if (line.Length > 1)
                {
                    stack.Push(line[1]);
                }
                if (line[0] == "2")
                {
                    if (stack.Count != 0)
                        stack.Pop();
                }
                if (stack.Count != 0)
                {
                    if (line[0] == "3")
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else if (line[0] == "4")
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
