using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace GenericCountMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            List<double> list = new List<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                list.Add(input);
            }
            double niz = double.Parse(Console.ReadLine());
            Boxe<double> box = new Boxe<double>(list);
            Console.WriteLine(box.Count(list,niz));
        }
    }
}
