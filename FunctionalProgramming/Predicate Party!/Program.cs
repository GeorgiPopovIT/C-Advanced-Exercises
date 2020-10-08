using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Party!")
                {
                    break;
                }
                string[] parts = input.Split().ToArray();
                Func<string, bool> func = GetFunc(parts);
                if (parts[0] == "Remove")
                {
                    people.RemoveAll(func);
                }
                else if (input.StartsWith("Double"))
                {

                }

            }
            if (people.Count != 0)
            {
                Console.WriteLine($"{string.Join(", ", people.OrderBy(x => x))} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Func<string, bool> GetFunc(string[] input)
        {
            string prType = input[0];
            string prArg = input[1];
            Func<string, bool> func = null;
            if (prType == "StartsWith")
            {
                func = new Func<string, bool>(x => x.StartsWith(prArg));
            }
            else if (prType == "EndsWith")
            {
                func = new Func<string, bool>(x => x.EndsWith(prArg));
            }
            else if (prType == "Length")
            {
                func = new Func<string, bool>(x => x.Length == int.Parse(prArg));
            }
            return func;
        }
    }
}
