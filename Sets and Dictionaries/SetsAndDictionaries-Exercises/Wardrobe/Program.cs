using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, int>> dict = new Dictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string currLine = Console.ReadLine();
                string[] splitted = currLine
                .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string color = splitted[0];
                string[] splittedClothes = splitted[1].Split(",");
                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new SortedDictionary<string, int>());
                }
                foreach (var clothe in splittedClothes)
                {
                    if (!dict[color].ContainsKey(clothe))
                    {
                        dict[color].Add(clothe, 0);
                    }
                    dict[color][clothe]++;
                }
            }
            string[] findClothes = Console.ReadLine().Split();
            string colorToFind = findClothes[0];
            string clotheToFind = findClothes[1];
            string pieceOfClothing = string.Empty;
            if (dict.ContainsKey(colorToFind) && dict[colorToFind].ContainsKey(clotheToFind))
            {
                pieceOfClothing = clotheToFind;
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var item in kvp.Value)
                {
                    if (item.Key == pieceOfClothing && kvp.Key == colorToFind)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
