using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int bulletCosCounter = 0;
            int priceBullet = int.Parse(Console.ReadLine());
            int sizeGunBarel = int.Parse(Console.ReadLine());
            var bullets = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>(bullets);
            var locks = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();
            var queue = new Queue<int>(locks);
            int intelligence = int.Parse(Console.ReadLine());
            while (true)
            {

                if (stack.Count == 0 && queue.Count != 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {queue.Count()}");
                    return;
                }
                if (count == sizeGunBarel && stack.Count != 0 && stack.Count != 0)
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }

                if (queue.Count == 0)
                {
                    break;
                }

                if (stack.Peek() > queue.Peek())
                {
                    Console.WriteLine("Ping!");
                    stack.Pop();
                    bulletCosCounter++;
                }
                else
                {
                    Console.WriteLine("Bang!");
                    queue.Dequeue();
                    stack.Pop();
                    bulletCosCounter++;
                }
                count++;
            }
            int bulletPrice = bulletCosCounter * priceBullet;
            intelligence -= bulletPrice;
            if (intelligence > 0)
            {
                Console.WriteLine($"{stack.Count} bullets left. Earned ${intelligence}");
            }
        }
    }
}
