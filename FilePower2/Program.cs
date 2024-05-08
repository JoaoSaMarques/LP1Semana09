using System;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("provide at least one string as an argument.");
                return;
            }

            string fileName = args[0];

            using (StreamWriter writer = File.CreateText(fileName))
            {
                for (int i = 1; i < args.Length; i++)
                {
                    writer.WriteLine(args[i]);
                }
            }

            Console.WriteLine("Strings have been saved to the file.");
        }
    }
}