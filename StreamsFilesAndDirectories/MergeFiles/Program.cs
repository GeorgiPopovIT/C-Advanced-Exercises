using System;
using System.IO;
using System.Text;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] result = File.ReadAllLines("input1.txt");
            string[] result2 = File.ReadAllLines("input2.txt");
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < result.Length; i++)
                {
                    writer.WriteLine(result[i]);
                    writer.WriteLine(result2[i]);
                }
            }

        }
    }
}
