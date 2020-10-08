using System;
using System.Linq;

namespace CountUpperCaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitted = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(n => n[0] == n.ToUpper()[0]).ToArray();
            Console.WriteLine(string.Join("\n", splitted));
        }
    }
}
