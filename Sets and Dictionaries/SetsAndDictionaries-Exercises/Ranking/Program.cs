using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> addCandidates = new Dictionary<string, Dictionary<string, int>>();
            var dict = new Dictionary<string, string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(":");
                if (input[0] == "end of contests")
                {
                    break;
                }
                string contest = input[0];
                string password = input[1];
                if (!dict.ContainsKey(input[0]))
                {
                    dict.Add(contest, password);
                }
            }
            while (true)
            {
                string[] input = Console.ReadLine().Split("=>");
                if (input[0] == "end of submissions")
                {
                    break;
                }
                string contest = input[0];
                string password = input[1];
                string name = input[2];
                int points = int.Parse(input[3]);
                if (dict.ContainsKey(contest) && dict[contest] == password)
                {
                    if (addCandidates.ContainsKey(name))
                    {
                        if (addCandidates[name].ContainsKey(contest))
                        {
                            if (addCandidates[name][contest] < points)
                            {
                                addCandidates[name][contest] = points;
                            }
                        }
                        else
                        {
                            addCandidates[name].Add(contest, points);
                        }
                    }
                    else
                    {
                        addCandidates.Add(name, new Dictionary<string, int>());
                        addCandidates[name].Add(contest, points);
                    }
                }
            }
            var champion = addCandidates.OrderByDescending(x => x.Value.Values.Sum())
                .ToDictionary(x => x.Key, x => x.Value);
            addCandidates = addCandidates.OrderBy(x => x.Key).
    ToDictionary(x => x.Key, x => x.Value.OrderByDescending(y => y.Value).ToDictionary(y => y.Key, y => y.Value));
            //var first = champion.Keys.First();
            foreach (var item in champion)
            {
                Console.WriteLine($"Best candidate is {item.Key} with total {item.Value.Values.Sum()} points.");
                break;
            }
            Console.WriteLine("Ranking:");
            foreach (var kvp in addCandidates)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
