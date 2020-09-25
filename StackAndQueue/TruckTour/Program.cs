using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<int[]>();
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray());
            }
            for (int i = 0; i < n; i++)
            {
                if (IsSolution(n, queue))
                {
                    Console.WriteLine(i);
                    break;
                }
                int[] startPomp = queue.Dequeue();
                queue.Enqueue(startPomp);
            }
        }
        static bool IsSolution(int n, Queue<int[]> queue)
        {
            int tankFuel = 0;
            bool foundAnswer = true;
            for (int i = 0; i < n; i++)
            {
                int[] currPomp = queue.Dequeue();
                tankFuel += currPomp[0] - currPomp[1];
                if (tankFuel < 0)
                {
                    foundAnswer = false;
                }
                queue.Enqueue(currPomp);
            }
            if (foundAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
