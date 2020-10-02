using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            using var reader = new StreamReader("text.txt");
            var line = reader.ReadLine();
            while (line != null)
            {
                if (count % 2 == 1)
                {
                    Console.WriteLine(line);
                }

                count++;
                line = reader.ReadLine();
            }

        }
    }
}
