using System;
using System.IO;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using var writer = new StreamWriter("output.txt");
            writer.WriteLine("hallo");
            writer.WriteLine("fsdd");
            writer.WriteLine("change");
        }
    }
}
