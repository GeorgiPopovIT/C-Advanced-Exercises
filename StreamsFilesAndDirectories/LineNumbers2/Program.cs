using System;
using System.IO;
using System.Linq;

namespace LineNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");
            string[] result = new string[lines.Length];
            int count = 1;
            foreach (var line in lines)
            {
                result[count - 1] = $"Line {count}: {line} ({CountOfLetters(line)})({CountOfSymbols(line)})";
                File.WriteAllLines("output.txt",result);
                count++;
            }
        }
        static int CountOfLetters(string line)
        {
            int counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char symbol = line[i];
                if (Char.IsLetter(symbol))
                {
                    counter++;
                }
            }
            return counter;
        }
        static int CountOfSymbols(string line)
        {
            int counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (Char.IsPunctuation(line[i]))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
