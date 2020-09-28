using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, SortedSet<string>>>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                if (tokens[0] == "Statistics")
                {
                    break;
                }
                string vlogerName = tokens[0];
                if (tokens.Contains("joined"))
                {
                    if (!dict.ContainsKey(vlogerName))
                    {
                        dict.Add(vlogerName, new Dictionary<string, SortedSet<string>>());
                        dict[vlogerName].Add("followers", new SortedSet<string>());
                        dict[vlogerName].Add("following", new SortedSet<string>());
                    }
                }
                else if (tokens.Contains("followed"))
                {
                    string vlogerName2 = tokens[2];
                    if (dict.ContainsKey(vlogerName2) && vlogerName != vlogerName2 && dict.ContainsKey(vlogerName))
                    {
                        dict[vlogerName]["following"].Add(vlogerName2);
                        dict[vlogerName2]["followers"].Add(vlogerName);

                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {dict.Count} vloggers in its logs.");
            dict = dict.OrderByDescending(x => x.Value["followers"].Count())
                .ThenBy(x => x.Value["following"].Count)
                .ToDictionary(x => x.Key, x => x.Value);

            string first = dict.Keys.First();
            int count = 2;
            foreach (var kvp in dict)
            {
                if (kvp.Key == first)
                {
                    Console.WriteLine($"1. {kvp.Key} : {kvp.Value["followers"].Count()} followers, {kvp.Value["following"].Count()} following");
                    foreach (var item in kvp.Value["followers"])
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
                else
                {
                    Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value["followers"].Count()} followers, {kvp.Value["following"].Count()} following");
                    count++;
                }
            }
            
        }
    }
}
