using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
           // string path = Directory.GetCurrentDirectory();
            Dictionary<string, Dictionary<string, double>> fileinfo = new Dictionary<string, Dictionary<string, double>>();
            DirectoryInfo directoryInfo = new DirectoryInfo("../../../");
            FileInfo[] files = directoryInfo.GetFiles(".");
            foreach (var file in files)
            {
                if (!fileinfo.ContainsKey(file.Extension))
                {
                    fileinfo.Add(file.Extension, new Dictionary<string, double>());
                }
                fileinfo[file.Extension].Add(file.Name, file.Length / 1000);
            }

            using var writer = new StreamWriter("report.txt");
            fileinfo = fileinfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key)
                .ToDictionary(x =>x.Key,x =>x.Value);
            foreach (var kvp in fileinfo)
            {
                writer.WriteLine(kvp.Key);
                foreach (var item in kvp.Value)
                {
                    writer.WriteLine($"--{item.Key} - {item.Value}kb");
                }
            }
        }
    }
}
