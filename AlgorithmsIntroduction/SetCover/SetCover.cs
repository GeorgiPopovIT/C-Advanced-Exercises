using System;
using System.Collections.Generic;
using System.Linq;

namespace SetCover
{
    public class SetCover
    {
        public static void Main(string[] args)
        {
            var universe = Console.ReadLine()
                .Split(new string[] { ", ",":" },StringSplitOptions.RemoveEmptyEntries).Skip(1).Select(int.Parse).ToArray();
            var setsInput = Console.ReadLine()
                .Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(setsInput[1]);
            int[][] sets = new int[n][];
            for (int row = 0; row < sets.Length; row++)
            {
                var inputNum = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                sets[row] = new int[inputNum.Length];
                for (int col = 0; col < sets[row].Length; col++)
                {
                    sets[row][col] = inputNum[col];
                }
            }

            List<int[]> selectedSets = ChooseSets(sets.ToList(), universe.ToList());
            Console.WriteLine($"Sets to take ({selectedSets.Count}):");

            foreach (int[] set in selectedSets)
            {
                Console.WriteLine($"{{ {string.Join(", ", set)} }}");
            }
        }
        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            var selectedSets = new List<int[]>();

            while (universe.Count > 0)
            {
                var currentSet = sets.OrderByDescending(s => s.Count(universe.Contains)).First();

                selectedSets.Add(currentSet);
                sets.Remove(currentSet);
                for (int i = 0; i < universe.Count; i++)
                {
                    universe.Remove(universe[i]);
                }
            }
            return selectedSets;
        }
    }
}
