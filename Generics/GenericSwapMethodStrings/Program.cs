using System;
using System.Linq;

namespace GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxStore<string> lst = new BoxStore<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Box<string> item = new Box<string>(input);
                lst.Add(item);
            }
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index1 = arr[0];
            int index2 = arr[1];
            lst.SwapMethod(index1, index2);
            Console.WriteLine(lst.ToString());
        }
    }
}
