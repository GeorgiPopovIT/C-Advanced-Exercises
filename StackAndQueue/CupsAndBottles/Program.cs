using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(cups);
            var bottles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(bottles);
            int result = 0;
            while (queue.Count != 0)
            {
                if (stack.Count == 0)
                {
                    break;
                }

                if (queue.Peek() <= 0)
                {
                    queue.Dequeue();
                    continue;
                }
                if (queue.Peek() > stack.Peek())
                {
                    int currCup = queue.Dequeue();
                    while (true)
                    {
                        int nowBottle = stack.Pop();
                        if (nowBottle < currCup)
                        {
                            currCup -= nowBottle;
                        }
                        else
                        {
                            result += nowBottle - currCup;
                            break;
                        }
                        if (stack.Count == 0)
                        {
                            Console.WriteLine($"Cups: {currCup + " " + string.Join(" ", cups)}");
                            Console.WriteLine("Wasted litters of water: " + result);
                            return;
                        }
                    }
                }
                else
                {
                    result += stack.Pop() - queue.Dequeue();
                }

            }
            if (queue.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", stack)}");
                Console.WriteLine($"Wasted litters of water: {result}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", queue)}");
                Console.WriteLine($"Wasted litters of water: {result}");
            }
        }
    }
}
