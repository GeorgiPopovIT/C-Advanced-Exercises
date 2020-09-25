using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine()
                .Split(", ")
                .ToArray();
            var queue = new Queue<string>(songs);
            while (true)
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    return;
                }
                string[] command = Console.ReadLine().Split(new[] { ' ' }, 2);
                if (command.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string song = command[1];
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                        continue;
                    }
                    queue.Enqueue(song);
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", queue));
                }

            }
        }
    }
}
