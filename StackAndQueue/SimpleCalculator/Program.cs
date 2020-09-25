using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var stack = new Queue<string>(input);
            int result = 0;
            while (stack.Count > 0)
            {
                var element = stack.Dequeue();
                if (element == "+")
                {
                    var number = stack.Dequeue();
                    result += int.Parse(number);
                }
                else if (element == "-")
                {
                    var number = stack.Dequeue();
                    result -= int.Parse(number);
                }
                else
                {
                    result = int.Parse(element);
                }
            }
            Console.WriteLine(result);
        }
    }
}
