using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var len = new int[sequence.Length];
            var prev = new int[sequence.Length];

            Array.Fill(prev, -1);

            var maxLen = 0;
            var lastIndex = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                var bestLength = 1;
                var prevIndex = -1;

                var currentNumber = sequence[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    var previousNumber = sequence[j];

                    if (previousNumber < currentNumber &&
                        bestLength <= len[j] + 1)
                    {
                        bestLength = len[j] + 1;
                        prevIndex = j;
                    }
                }

                if (bestLength > maxLen)
                {
                    maxLen = bestLength;
                    lastIndex = i;
                }

                len[i] = bestLength;
                prev[i] = prevIndex;
            }

            var longestSequence = new Stack<int>();

            while (lastIndex != -1)
            {
                longestSequence.Push(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}