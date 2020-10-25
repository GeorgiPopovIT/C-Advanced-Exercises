using System;
using System.Collections.Generic;
using System.Linq;
namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int taskToBeKilled = int.Parse(Console.ReadLine());

            var tasks = new Stack<int>(input1);
            var threads = new Queue<int>(input2);

            while (true)
            {
                if (tasks.Peek() == taskToBeKilled)
                {
                    break;
                }
                if (threads.Peek() >= tasks.Peek())
                {
                    threads.Dequeue();
                    tasks.Pop();
                }
                else
                {
                    threads.Dequeue();
                }

            }

            Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskToBeKilled}");

            Console.WriteLine(String.Join(" ", threads));
        }
    }
}
