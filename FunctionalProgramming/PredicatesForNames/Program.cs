using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicatesForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Func<string, bool> checker = x => x.Length <= n;
            Action<string[]> printer = x => Console.WriteLine(string.Join("\n",x));
            var names = Console.ReadLine().Split().Where(checker).ToArray();
            printer(names);
        }
    }
}
