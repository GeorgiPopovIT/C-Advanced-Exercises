using System;
using System.Linq;

namespace KnightsForHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split().ToArray();
            Action<string> printer = x => Console.WriteLine($"Sir {x}");
            Array.ForEach(input, printer);
        }
    }
}
