using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            // 50p./100p.
            int startRow = 0;
            int startCol = 0;
            int coalCount = 0;
            var list = new List<string>();
            int n = int.Parse(Console.ReadLine());
            var commands = Console.ReadLine().Split(' ').ToArray();
            string[,] matrix = new string[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                    if (matrix[row, col] == "c")
                    {
                        coalCount++; ;
                    }
                    if (matrix[row, col] == "s")
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    row = startRow;
                    col = startCol;
                    for (int i = 0; i < commands.Length; i++)
                    {
                        if (commands[i] == "up")
                        {
                            if (row - 1 > 0)
                            {
                                row--;
                            }
                            if (matrix[row, col] == "e")
                            {
                                Console.WriteLine($"Game over! ({row}, {col})");
                                return;
                            }
                            else if (matrix[row, col] == "c")
                            {
                                if (!list.Contains($"{row}, {col}"))
                                {
                                    coalCount -= 1;
                                    list.Add($"{row}, {col}");
                                }

                                if (coalCount == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({row}, {col})");
                                }
                            }

                        }
                        else if (commands[i] == "left")
                        {
                            if (col - 1 >= 0)
                            {
                                col--;
                            }
                            if (matrix[row, col] == "e")
                            {
                                Console.WriteLine($"Game over! ({row}, {col})");
                                return;
                            }
                            else if (matrix[row, col] == "c")
                            {
                                if (!list.Contains($"{row}, {col}"))
                                {
                                    coalCount -= 1;
                                    list.Add($"{row}, {col}");
                                }
                                if (coalCount == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({row}, {col})");
                                }
                            }
                        }
                        else if (commands[i] == "right")
                        {
                            if (col + 1 < matrix.GetLength(1))
                            {
                                col++;
                            }
                            if (matrix[row, col] == "e")
                            {
                                Console.WriteLine($"Game over! ({row}, {col})");
                                return;
                            }
                            else if (matrix[row, col] == "c")
                            {
                                if (!list.Contains($"{row}, {col}"))
                                {
                                    coalCount -= 1;
                                    list.Add($"{row}, {col}");
                                }
                                if (coalCount == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({row}, {col})");
                                    return;
                                }
                            }
                        }
                        else if (commands[i] == "down")
                        {
                            if (row + 1 < matrix.GetLength(0))
                            {
                                row++;
                            }
                            if (matrix[row, col] == "e")
                            {
                                Console.WriteLine($"Game over! ({row}, {col})");
                                return;
                            }
                            else if (matrix[row, col] == "c")
                            {
                                if (!list.Contains($"{row}, {col}"))
                                {
                                    coalCount -= 1;
                                    list.Add($"{row}, {col}");
                                }
                                if (coalCount == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({row}, {col})");
                                    return;
                                }
                            }
                        }
                    }
                    if (coalCount > 0)
                    {
                        Console.WriteLine($"{coalCount} coals left. ({row}, {col})");
                        return;
                    }
                }
            }
        }
    }
}
