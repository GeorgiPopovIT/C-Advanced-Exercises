using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            var input = Console.ReadLine().Split();
            int pushNum = int.Parse(input[0]);
            int popNum = int.Parse(input[1]);
            string lookNum = input[2];
            var numbers = Console.ReadLine().Split();
            if (pushNum == numbers.Length)
            {
                for (int i = 0; i < pushNum; i++)
                {
                    stack.Push(numbers[i]);
                }
                for (int i = 0; i < popNum; i++)
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else if (stack.Contains(lookNum))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
