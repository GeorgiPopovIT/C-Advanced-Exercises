using System;
using System.IO;
using System.IO.Compression;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\Users\Georges\Desktop\zipToExtract"
, @"C:\Users\Georges\Desktop\extractdirectory\myZipFile.zip");
         ZipFile.ExtractToDirectory(@"C:\Users\Georges\Desktop\extractdirectory\myZipFile.zip"
, @"C:\Users\Georges\Desktop\resultPath");

        }
    }
}
