using System;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string> printer = Print;
            for (int i = 0; i < input.Length; i++)
            {
                printer(input[i]);
            }
        }
        static void Print(string input)
        {
            Console.WriteLine(String.Join(Environment.NewLine, input));
        }
    }
}
