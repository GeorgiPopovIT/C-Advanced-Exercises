using System;
using System.IO;

namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string directorypath = Console.ReadLine();
            Console.WriteLine(GetDirectorySize(directorypath,0));
        }
        static double GetDirectorySize(string directorypath,int identetion)
        {
            string[] files = Directory.GetFiles(directorypath);
            
            double sum = 0;

            string[] directories = Directory.GetDirectories(directorypath);
            for (int i = 0; i < directories.Length; i++)
            {
                Console.WriteLine($"{new string(' ', identetion)}{directories[i]}");
                sum += GetDirectorySize(directories[i],identetion + 5);
            }
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"{new string ('-',identetion)}{info.Name} --> {info.Length} bytes");
                sum += info.Length;
            }
            return sum;
        }
    }
}
