using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var setN = new HashSet<int>();
            var setM = new HashSet<int>();
            for (int i = 0; i < input[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                setN.Add(number);
            }
            for (int i = 0; i < input[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                setM.Add(number);
            }
            Console.WriteLine(string.Join(" ",setN.Intersect(setM)));
        }
    }
}
