using System;
using System.Linq;

namespace DiagonalDiffrence
{
    class Program
    {
        static void Main(string[] args)
        {
            int leftSum = 0;
            int rightSum = 0;
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = row; col < matrix.GetLength(1); col++)
                {
                    leftSum += matrix[row, col];
                    break;
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1) - row - 1; col >= 0; col--)
                {
                    rightSum += matrix[row, col];
                    break;
                }
            }
            Console.WriteLine(Math.Abs(leftSum - rightSum));
        }
    }
}
