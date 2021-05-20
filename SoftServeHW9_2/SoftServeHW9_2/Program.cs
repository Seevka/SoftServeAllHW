using System;
using System.IO;
using System.Linq;

namespace SoftServeHW9_2
{
    class Program
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Sevka\source\repos\SoftServeHW9_2\SoftServeHW9_2\MyTXT.txt");
            int count = 1;
            foreach(var line in lines)
            {
                Console.WriteLine($"{count} line have {line.Length} symbols");
                count += 1;
            }
            var longestLine = lines.FirstOrDefault(x => x.Length == lines.Max(x => x.Length));
            var shortestLine = lines.FirstOrDefault(x => x.Length == lines.Min(x => x.Length));
            Console.WriteLine($"The longest line : {longestLine} with {longestLine.Length} symbols\r\nThe shortest line : {shortestLine} with {shortestLine.Length} symbols");
            var varLine = from line in lines where line.Contains("var") select line;
            Console.WriteLine("Lines with var word: ");
            foreach(var line in varLine.ToList())
            {
                Console.WriteLine(line);
            }
        }
    }
}
