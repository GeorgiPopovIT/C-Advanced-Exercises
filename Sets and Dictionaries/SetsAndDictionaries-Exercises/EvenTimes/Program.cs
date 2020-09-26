using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string number = Console.ReadLine();
                if (!dict.ContainsKey(number))
                {
                    dict.Add(number, 1);
                }
                else
                {
                    dict[number]++;
                }
               
            }
            dict  = dict.Where(x => x.Value % 2 == 0).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
            }

        }
    }
}
