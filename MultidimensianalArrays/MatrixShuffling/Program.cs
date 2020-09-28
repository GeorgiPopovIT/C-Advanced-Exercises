using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse).ToArray();
            string[,] matrix = ReadMatrix(size[0], size[1]);

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                var parts = input.Split();
                if (input.StartsWith("swap ") && parts.Length == 5)
                {
                    int row1 = int.Parse(parts[1]);
                    int col1 = int.Parse(parts[2]);
                    int row2 = int.Parse(parts[3]);
                    int col2 = int.Parse(parts[4]);
                    if (row1 >= 0 && row1 < size[0] && col1 >= 0 && col1 < size[1] &&
                        row2 >= 0 && row2 < size[0] && col2 >= 0 && col2 < size[1])
                    {
                        var swap = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = swap;
                        PrintMatrix(matrix);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }
        }
        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
