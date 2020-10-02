using System;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"";
            var files = Directory.GetFiles("TestFolder");
            double sum = 0;
            foreach (var file in files)
            {
                FileInfo fileinfo = new FileInfo(file);
                sum+=fileinfo.Length;
            }
            using var writer = new StreamWriter("output.txt");
            writer.Write(sum / 1024 / 1024);
        }
    }
}
