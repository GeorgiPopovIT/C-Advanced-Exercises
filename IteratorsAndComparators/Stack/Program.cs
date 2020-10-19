using System;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                var parts = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts[0] == "Push")
                {
                    var nums = parts.Skip(1).Select(int.Parse).ToArray();
                    foreach (var item in nums)
                    {
                        stack.Push(item);
                    }
                }
                else if (parts[0] == "Pop")
                {
                    stack.Pop();
                }
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
