using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();
            while (true)
            {
                var input = Console.ReadLine().Split(", ").ToArray();
                if (input[0] == "Revision")
                {
                    break;
                }
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!dict.ContainsKey(shop))
                {
                    dict.Add(shop, new Dictionary<string, double>());
                }
                if (!dict[shop].ContainsKey(product))
                {
                    dict[shop].Add(product, price);
                }
            }
            foreach (var shop in dict)
            {
                Console.WriteLine($"{shop.Key}");
                foreach (var kvp in shop.Value)
                {
                    Console.WriteLine($"Product: {kvp.Key}, Price: {kvp.Value}");
                }
            }
        }
    }
}
