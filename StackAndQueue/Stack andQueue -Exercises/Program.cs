using System;
using System.Collections.Generic;

namespace Stack_andQueue__Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>(input);
            foreach (var @char in stack)
            {
                Console.Write(@char);
            }
        }
    }
}
