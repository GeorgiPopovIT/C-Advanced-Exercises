using System;
using System.Linq;

namespace JaggedArray_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];
            for (int row = 0; row < jagged.Length; row++)
            {
                var inputNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = new int[inputNum.Length];
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = inputNum[col];
                }
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var parts = line.Split();
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);
                if (row < 0 || row > jagged.Length - 1 || col < 0 || col > jagged[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (line.StartsWith("Add"))
                {
                    jagged[row][col] += value;
                }
                else if (line.StartsWith("Subtract"))
                {
                    jagged[row][col] -= value;
                }

            }

            foreach (var array in jagged)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
