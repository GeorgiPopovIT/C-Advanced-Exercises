using System;
using System.IO;

namespace SliceFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using var stream = new FileStream("slice.txt", FileMode.OpenOrCreate);
            var parts = 4;
            var length = (int)Math.Ceiling(stream.Length / (decimal)parts);
            var buffer = new byte[length];
            for (int i = 0; i < parts; i++)
            {
                var byteToRead = stream.Read(buffer, 0, buffer.Length);
                if (byteToRead < buffer.Length)
                {

                }
                using var partsStream = new FileStream($"Part{i + 1}.txt", FileMode.OpenOrCreate);
                partsStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
