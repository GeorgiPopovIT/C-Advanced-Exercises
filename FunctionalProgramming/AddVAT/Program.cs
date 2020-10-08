using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> opearation = n => n * 1.20;
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).Select(opearation).ToArray();
            Console.WriteLine(string.Join("\n", input.Select(x => x.ToString("F2"))));
        }
    }
}
