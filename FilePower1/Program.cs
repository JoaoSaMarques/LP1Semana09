using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 2)
            {
                Console.WriteLine("provide at least one string as arguments.");
                return;
            }

            string fileName = args[0];
            List<string> stringList = new List<string>();

            for (int i = 1; i < args.Length; i++)
            {
                stringList.Add(args[i]);
            }

            File.WriteAllLines(fileName, stringList);

            Console.WriteLine("Strings have been saved to the file.");
        }
    }
}