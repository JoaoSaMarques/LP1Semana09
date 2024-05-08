using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste das coleções genéricas
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            HashSet<int> hashSet = new HashSet<int>();

            int[] values = { 1, 10, -30, 10, -5 };

            foreach (int value in values)
            {
                list.Add(value);
                stack.Push(value);
                queue.Enqueue(value);
                hashSet.Add(value);
            }
        }
    }
}
