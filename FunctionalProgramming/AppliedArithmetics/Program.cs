using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Action<List<int>> print = n => Console.WriteLine(string.Join(" ", input));
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                if (command == "print")
                {
                    print(input);
                }
                Func<int, int> opeartions = n =>
                {
                    switch (command)
                    {
                        case "add": return n + 1;
                        case "multiply": return n * 2;
                        case "subtract": return n - 1;
                        default:
                            return n;
                    }
                };
                input = input.Select(opeartions).ToList();
            }
        }
    }
}
