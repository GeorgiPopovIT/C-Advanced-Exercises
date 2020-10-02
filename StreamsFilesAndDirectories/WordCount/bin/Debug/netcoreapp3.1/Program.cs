using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            using var reader = new StreamReader("text.txt");
            using var wordsReader = new StreamReader("words.txt");
            string words = wordsReader.ReadLine();
            string[] parts = words.Split();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine().ToLower();
                for (int i = 0; i < parts.Length; i++)
                {
                    if (line.Contains(parts[i]))
                    {
                        if (!dict.ContainsKey(parts[i]))
                        {
                            dict.Add(parts[i], 1);
                        }
                        else
                        {
                            dict[parts[i]]++;
                        }

                    }
                }
            }
            using var writer = new StreamWriter("output.txt");
            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key,x => x.Value);
            foreach (var item in dict)
            {
                writer.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
