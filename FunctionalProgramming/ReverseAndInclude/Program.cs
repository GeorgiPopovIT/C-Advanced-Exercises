using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndInclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int n = int.Parse(Console.ReadLine());
            Func<int, bool> isEvenOrOdd = x => x % n != 0;
            input = input.Where(isEvenOrOdd).ToList();
            Action<List<int>> printer = x => Console.WriteLine(string.Join(" ", x));
            printer(input);
        }
    }
}
