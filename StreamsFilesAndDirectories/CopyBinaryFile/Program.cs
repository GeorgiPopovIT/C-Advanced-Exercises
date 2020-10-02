using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new FileStream("../../../copyMe.png",FileMode.Open);

            using var writer = new FileStream("newfile.png", FileMode.OpenOrCreate);

            var buffer = new byte[4096];
            while (reader.CanRead)
            {
                int byteRead = reader.Read(buffer, 0, buffer.Length);
                if (byteRead == 0)
                {
                    break;
                }
                writer.Write(buffer, 0, buffer.Length);
            }

        }
    }
}
