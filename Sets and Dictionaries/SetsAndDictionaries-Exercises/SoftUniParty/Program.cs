using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[0-9][A-Za-z]+";

            var vipSet = new HashSet<string>();
            var regularSet = new HashSet<string>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line.StartsWith("PARTY"))
                {
                    break;
                }
                var match = Regex.Match(line, pattern);
                if (match.Success)
                {
                    vipSet.Add(line);
                }
                else
                {
                    regularSet.Add(line);
                }
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line.StartsWith("END"))
                {
                    break;
                }
                if (vipSet.Contains(line))
                {
                    vipSet.Remove(line);
                }
                else if (regularSet.Contains(line))
                {
                    regularSet.Remove(line);
                }
            }
            Console.WriteLine(regularSet.Count + vipSet.Count);
            foreach (var item in vipSet)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regularSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
