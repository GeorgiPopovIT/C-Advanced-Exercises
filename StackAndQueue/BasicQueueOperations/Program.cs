using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            var input = Console.ReadLine().Split();
            int enqueueNum = int.Parse(input[0]);
            int dequeueNum = int.Parse(input[1]);
            string lookNum = input[2];
            var numbers = Console.ReadLine().Split();

            for (int i = 0; i < enqueueNum; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < dequeueNum; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(lookNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
