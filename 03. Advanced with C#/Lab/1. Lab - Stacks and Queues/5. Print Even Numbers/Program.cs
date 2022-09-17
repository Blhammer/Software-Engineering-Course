using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> output = new Queue<int>(input);

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = output.Peek();

                if (currentNumber % 2 == 0)
                {
                    output.Enqueue(currentNumber);
                }
                
                output.Dequeue();
            }

            foreach (var number in output)
            {
                if (number == output.Last())
                {
                    Console.Write($"{number}");
                    break;
                }

                Console.Write($"{number}, ");
            }
        }
    }
}
