using System;
using System.IO;
using System.Linq;
using System.Text;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            using var reader = new StreamReader("text.txt");
            int counter = 0;
            char[] characterToReplace = new char[] { '-', ',', '.', '!', '?' };
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (counter % 2 == 0)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char symbol = line[i];
                        if (characterToReplace.Contains(symbol))
                        {
                            line = line.Replace(symbol, '@');
                        }
                    }
                    var splitted = line.Split().ToArray();
                    for (int i = splitted.Length - 1; i >= 0; i--)
                    {
                        sb.Append(splitted[i]);
                    }
                    Console.WriteLine(sb);
                    sb.Clear();
                }
                counter++;
            }
        }
    }
}
