using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var input1 = Console.ReadLine().Split().ToArray();
            var fullName = input1[0] + " " + input1[1];
            var address = input1[2];
            var town = input1[3];
            Threeuple<string, string, string> tuple1 = new Threeuple<string, string, string>(fullName, address, town);
            Console.WriteLine(tuple1.ToString());

            var input2 = Console.ReadLine().Split().ToArray();
            var name = input2[0];
            var litterOfBeer = int.Parse(input2[1]);
            bool drunkOrNot = input2[2] == "drunk" ? true : false;
            Threeuple<string, int, bool> tuple2 = new Threeuple<string, int, bool>(name, litterOfBeer, drunkOrNot);
            Console.WriteLine(tuple2.ToString());

            var input3 = Console.ReadLine().Split().ToArray();
            Threeuple<string, double, string> tuple3 = new Threeuple<string, double, string>(input3[0], double.Parse(input3[1]), input3[2]);
            Console.WriteLine(tuple3.ToString());
        }
    }
}
