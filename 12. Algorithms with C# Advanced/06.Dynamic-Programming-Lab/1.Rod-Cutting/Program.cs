using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyApp
{
    public class Program
    {
        private static int[] memo;
        private static int[] prev;
        private static List<int> parts;

        public static void Main()
        {
            var price = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            memo = new int[price.Length];
            prev = new int[price.Length];

            var length = int.Parse(Console.ReadLine());

            var bestPrice = CutRod(price, length);

            parts = new List<int>();

            PrintResult(length, bestPrice);
        }

        private static void PrintResult(int length, int bestPrice)
        {
            Console.WriteLine(bestPrice);

            while (length != 0)
            {
                var currentPrev = prev[length];

                parts.Add(currentPrev);

                length -= currentPrev;
            }

            Console.WriteLine(string.Join(" ", parts));
        }

        private static int CutRod(int[] price, int length)
        {
            if (length == 0)
            {
                return 0;
            }

            if (memo[length] != 0)
            {
                return memo[length];
            }

            var bestPrice = price[length];
            var bestCombo = length;

            for (int i = 1; i < length; i++)
            {
                var currentPrice = price[i] + CutRod(price, length - i);

                if (currentPrice > bestPrice)
                {
                    bestPrice = currentPrice;
                    bestCombo = i;
                }
            }

            memo[length] = bestPrice;
            prev[length] = bestCombo;

            return bestPrice;
        }
    }
}