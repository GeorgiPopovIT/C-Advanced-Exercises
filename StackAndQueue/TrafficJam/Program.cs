using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int count = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                else if (line == "green")
                {

                    for (int i = 0; i < n; i++)
                    {

                        if (queue.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                    }
                }
                else
                {
                    queue.Enqueue(line);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
