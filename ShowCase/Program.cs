using System;
using StringCompression;

namespace ShowCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to compress: ");
            
            Console.WriteLine(Compression.Compress(Console.ReadLine() ?? string.Empty));
        }
    }
}
