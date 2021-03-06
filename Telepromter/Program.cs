using System;
using System.Collections.Generic;
using System.IO;

namespace Telepromter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var lines = ReadFrom("LoremIpsum.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

    }
}

