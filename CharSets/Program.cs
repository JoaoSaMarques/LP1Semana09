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
        }
    }
}
