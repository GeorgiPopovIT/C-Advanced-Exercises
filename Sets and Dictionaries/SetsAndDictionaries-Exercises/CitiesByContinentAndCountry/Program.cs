using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> contries = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] currLine = Console.ReadLine().Split();
                string continent = currLine[0];
                string country = currLine[1];
                string city = currLine[2];
                if (!contries.ContainsKey(continent))
                {
                    contries.Add(continent, value: new Dictionary<string, List<string>>());
                }
                if (!contries[continent].ContainsKey(country))
                {
                    contries[continent].Add(country, new List<string>());
                }
                contries[continent][country].Add(city);
            }
            foreach (var kvp in contries)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
