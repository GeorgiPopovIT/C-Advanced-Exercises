using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int result = 0;
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>(numbers);
            while (stack.Count != 0)
            {
                result += stack.Peek();
                if (result > n)
                {
                    //stack.Push(stack.Peek());
                    count++;
                    result = 0;
                }
                else if (result == n)
                {
                    stack.Pop();
                    count++;
                    result = 0;
                }
                else if (stack.Count == 1)
                {
                    count++;
                    break;
                }
                else
                {
                    stack.Pop();
                }
            }
            Console.WriteLine(count);
        }
    }
}
