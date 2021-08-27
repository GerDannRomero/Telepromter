using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Telepromter
{
    class Program
    {
        static void Main(string[] args)
        {
            int timing = 300;
            var file = ReadFileName("LoremIpsum.txt");
            foreach (var line in file)
            {
                Console.Write(line);
                if (!string.IsNullOrWhiteSpace(line))
                {
                    var pause = Task.Delay(timing);





                    pause.Wait();
                }
            }
        }
        static IEnumerable<string> ReadFileName(string file)
        {
            var lineLength = 0;
            string line;
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    var words = line.Split(' ');
                    foreach (var word in words)
                    {
                        yield return word + " ";

                        lineLength += word.Length + 1;
                        if (lineLength > 100)
                        {
                            yield return Environment.NewLine;
                            lineLength = 0;
                        }

                    }
                    yield return Environment.NewLine;

                }
            }
        }

        //private static async Task ShowTeleprompter()
        //{
        //    var words = ReadFileName("LoremIpsum.txt");
        //    foreach (var word in words)
        //    {
        //        Console.Write(word);
        //        if (!string.IsNullOrWhiteSpace(word))
        //        {
        //            await Task.Delay(200);
        //        }
        //    }
        //}

    }
}

