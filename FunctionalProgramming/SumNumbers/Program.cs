using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = Parser;
            var input = Console.ReadLine().Split(", ")
                .Select(parser).ToArray();
            Console.WriteLine(input.Count());
            Console.WriteLine(input.Sum());

        }
        static int Parser(string n) => int.Parse(n);
    }
}
