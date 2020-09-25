using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var queue = new Queue<string>();
            int count = 0;
            while (input != "End")
            {
                if (input == "Paid")
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    count = 0;
                }
                else
                {
                    queue.Enqueue(input);
                    count++;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
