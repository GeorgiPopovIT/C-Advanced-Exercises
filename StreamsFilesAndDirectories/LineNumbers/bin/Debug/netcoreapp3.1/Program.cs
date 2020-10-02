using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("../../../input.txt");
            {
                using var writer = new StreamWriter("output.txt");
                {
                    int index = 1;
                    var line = reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        var convLine = $"{index} {line}";
                        writer.WriteLine(convLine);
                        line = reader.ReadLine();
                        index++;
                    }
                }
            }
        }
    }
}
