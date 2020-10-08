using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> minNum = x => x.Min();
            var input = Console.ReadLine().Split()
               .Select(int.Parse).ToArray();
            Console.WriteLine(minNum(input));
        }
    }
}
