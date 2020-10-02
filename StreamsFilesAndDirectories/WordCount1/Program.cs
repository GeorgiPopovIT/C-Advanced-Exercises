using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] words = File.ReadAllLines("words.txt");
            string[] text = File.ReadAllLines("text.txt");
            foreach (var word in words)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    var currLine = text[i].ToLower();
                    if (currLine.Contains(word))
                    {
                        if (!dict.ContainsKey(word))
                            dict.Add(word, 1);
                        else
                            dict[word]++;
                    }
                }
            }
            int counter = 0;
            string[] array = new string[dict.Count];
            foreach (var item in dict)
            {
                array[counter] = $"{item.Key} - {item.Value}";
                counter++;
            }
            File.WriteAllLines("actualResult.txt", array);

            counter = 0;
            foreach (var item in dict.OrderByDescending(x => x.Value))
            {
                array[counter] = $"{item.Key} - {item.Value}";
                counter++;
            }
            File.WriteAllLines("expectedResult.txt", array);
        }
    }
}
