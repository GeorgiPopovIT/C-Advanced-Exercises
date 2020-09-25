using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var queue = new Queue<string>(input);
            int n = int.Parse(Console.ReadLine());
            while (queue.Count != 1)
            {
                for (int i = 1; i < n; i++)
                {
                    queue.Enqueue(queue.Dequeue());

                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
