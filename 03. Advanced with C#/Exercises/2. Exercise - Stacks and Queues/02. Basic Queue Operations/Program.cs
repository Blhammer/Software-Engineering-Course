using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int n = input[0];
            int s = input[1];
            int x = input[2];

            Queue<int> operations = new Queue<int>();

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                int token = numbers[i];
                operations.Enqueue(token);
            }

            for (int i = 0; i < s; i++)
            {
                operations.Dequeue();
            }

            if (operations.Count == 0)
            {
                Console.WriteLine('0');
            }
            else if (operations.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                var smallestNumber = operations.Min();
                Console.WriteLine(smallestNumber);
            }
        }
    }
}
