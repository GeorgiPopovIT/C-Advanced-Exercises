using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfCoins
{
    public class SumOfCoins
    {
        public static void Main(string[] args)
        {
            var coins = Console.ReadLine()
                .Split(new string[] {":",", " },StringSplitOptions.RemoveEmptyEntries)
                .Skip(1).Select(int.Parse).ToArray();
            var input = Console.ReadLine()
                 .Split(new string[] { ":", ", " }, StringSplitOptions.RemoveEmptyEntries);
            var targetSum = int.Parse(input[1]);

            var selectedCoins = ChooseCoins(coins, targetSum);
            Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");

            foreach (var item in selectedCoins)
            {
                Console.WriteLine($"{item.Value} coin(s) with value {item.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            var sortedCoins = coins.OrderByDescending(c => c).ToList();

            var chooseCoins = new Dictionary<int, int>();
            var currSum = 0;
            int coinIndex = 0;

            while (currSum != targetSum && coinIndex < sortedCoins.Count)
            {
                var currCoinValue = sortedCoins[coinIndex];

                var remainingSum = targetSum - currSum;

                var numberOfCoinsToTake = remainingSum / currCoinValue;

                if (numberOfCoinsToTake > 0)
                {
                    chooseCoins.Add(currCoinValue, numberOfCoinsToTake);
                    currSum += currCoinValue;
                }
                coinIndex++;
            }
            return chooseCoins;
        }
    }
}
