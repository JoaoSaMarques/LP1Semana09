using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CharSets
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No files specified.");
                return;
            }

            var charSets = new List<HashSet<char>>();

            foreach (string file in args)
            {
                try
                {
                    var chars = new HashSet<char>();
                    foreach (string line in File.ReadLines(file))
                    {
                        if (line.Length!= 1)
                        {
                            throw new Exception($"File {file} has a line" +
                            "with more than one character.");
                        }
                        chars.Add(line[0]);
                    }
                    charSets.Add(chars);
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return;
                }

                var intersection = charSets.Aggregate(new HashSet<char>(), 
                (a, b) => new HashSet<char>(a.Intersect(b)));

                foreach (char c in intersection.OrderBy(x => x))
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
