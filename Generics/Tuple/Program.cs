using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var input = Console.ReadLine().Split().ToArray();
            var str = $"{input[0]} {input[1]}";
            Tuple<string, string> tuple1 = new Tuple<string, string>(str, input[2]);
            Console.WriteLine(tuple1.ToString());

            var input2 = Console.ReadLine().Split().ToArray();
            Tuple<string, int> tuple2 = new Tuple<string, int>(input2[0], int.Parse(input2[1]));
            Console.WriteLine(tuple2.ToString());

            var input3 = Console.ReadLine().Split().ToArray();
            Tuple<int, double> tuple3 = new Tuple<int, double>(int.Parse(input3[0]), double.Parse(input3[1]));
            Console.WriteLine(tuple3.ToString());
        }
    }
}
