using System;
using System.Linq;

namespace JaggedArray_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] matrix = ReadMatrix(n);
            for (int row = 0; row < matrix.Length - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int rowCurrent = row; rowCurrent <= row + 1; rowCurrent++)
                    {
                        for (int col = 0; col < matrix[rowCurrent].Length; col++)
                        {
                            matrix[rowCurrent][col] = matrix[rowCurrent][col] * 2;
                        }
                    }
                }
                else
                {
                    for (int rowCurrent = row; rowCurrent <= row + 1; rowCurrent++)
                    {
                        for (int col = 0; col < matrix[rowCurrent].Length; col++)
                        {
                            matrix[rowCurrent][col] = matrix[rowCurrent][col] * 0.5;
                        }
                    }
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                var parts = input.Split();
                if (parts[0] == "Add")
                {
                    int row = int.Parse(parts[1]);
                    int col = int.Parse(parts[2]);
                    int value = int.Parse(parts[3]);
                    if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }
                }
                else if (parts[0] == "Subtract")
                {
                    int row = int.Parse(parts[1]);
                    int col = int.Parse(parts[2]);
                    int value = int.Parse(parts[3]);
                    if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }
                }
            }
            PrintMatrix(matrix);
        }
        static double[][] ReadMatrix(int rows)
        {
            double[][] matrix = new double[rows][];
            for (int row = 0; row < matrix.Length; row++)
            {
                var rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                matrix[row] = new double[rowData.Length];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }
            return matrix;
        }
        static void PrintMatrix(double[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
