using System;
using System.Linq;

namespace MultidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {

            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            Read(matrix);

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Bloom Bloom Plow")
                {
                    break;
                }
                var nums = input.Split().Select(int.Parse).ToArray();
                if (IsOutside(size[0], nums[0], nums[1]))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                //var curr = matrix[nums[0], nums[1]];
                for (int row = nums[0]; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] += 1;
                    }
                    break;
                }
                for (int col = nums[1]; col < matrix.GetLength(1); col++)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        if (row != nums[0])
                        {
                            matrix[row, col] += 1;
                        }
                    }
                    break;
                }
            }
            Print(matrix);

        }
        private static void Print(int[,] matrix)
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
        private static void Read(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;

                }
            }
        }
        static bool IsOutside(int size, int row, int col)
        {
            return row > size - 1 || col > size - 1 || row < 0 || col < 0;
        }
    }
}
