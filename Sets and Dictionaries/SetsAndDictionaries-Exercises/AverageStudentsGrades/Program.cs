using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentsGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> dict = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<decimal>());
                }
                dict[name].Add(grade);
            }
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {string.Join(" ",kvp.Value.Select(x => x.ToString("F2")))} (avg: {kvp.Value.Average():F2})");
            }
        }
    }
}
