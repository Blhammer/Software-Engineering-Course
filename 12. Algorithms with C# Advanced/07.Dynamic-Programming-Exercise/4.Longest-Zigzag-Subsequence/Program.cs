using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[,] dp = new int[2, numbers.Length];
            dp[0, 0] = 1;
            dp[1, 0] = 1;

            int[,] parent = new int[2, numbers.Length];
            parent[0, 0] = -1;
            parent[1, 0] = -1;

            int bestLength = 0;
            int lastRowIndex = 0;
            int lastColIndex = 0;

            for (int current = 0; current < numbers.Length; current++)
            {
                int currentNumber = numbers[current];

                for (int prev = current - 1; prev >= 0; prev--)
                {
                    int prevNumber = numbers[prev];

                    if (currentNumber > prevNumber &&
                        dp[1, prev] + 1 >= dp[0, current])
                    {
                        dp[0, current] = dp[1, prev] + 1;
                        parent[0, current] = prev;
                    }

                    if (currentNumber < prevNumber &&
                        dp[0, prev] + 1 >= dp[1, current])
                    {
                        dp[1, current] = dp[0, prev] + 1;
                        parent[1, current] = prev;
                    }
                }

                if (dp[0, current] > bestLength)
                {
                    bestLength = dp[0, current];

                    lastRowIndex = 0;
                    lastColIndex = current;
                }

                if (dp[1, current] > bestLength)
                {
                    bestLength = dp[1, current];

                    lastRowIndex = 1;
                    lastColIndex = current;
                }
            }

            Stack<int> sequence = new Stack<int>();

            while (lastColIndex != -1)
            {
                sequence.Push(numbers[lastColIndex]);

                lastColIndex = parent[lastRowIndex, lastColIndex];

                lastRowIndex = lastRowIndex == 0 ? 1 : 0;
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}