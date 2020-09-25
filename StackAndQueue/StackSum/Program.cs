using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split().Select(int.Parse);
            var stack = new Stack<int>(numbers);
            while (true)
            {
                var input = Console.ReadLine().Split();
                var command = input[0].ToLower();
                if (command == "add")
                {
                    stack.Push(int.Parse(input[1]));
                    stack.Push(int.Parse(input[2]));
                }
                else if (command == "remove")
                {
                    if (stack.Count > int.Parse(input[1]))
                    {
                        for (int i = 0; i < int.Parse(input[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
