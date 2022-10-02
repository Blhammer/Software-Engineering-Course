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
            var words = Console.ReadLine().Split();

            var len = new int[words.Length];
            var parent = new int[words.Length];
            var maxLen = 0;
            var lastIndex = 0;

            for (int current = 0; current < words.Length; current++)
            {
                var currentStr = words[current];
                var currentBestLength = 1;
                var currentParent = -1;

                for (int prev = current - 1; prev >= 0; prev--)
                {
                    var prevStr = words[prev];
                    var prevLen = len[prev];

                    if (currentStr.Length > prevStr.Length &&
                        prevLen + 1 >= currentBestLength)
                    {
                        currentBestLength = prevLen + 1;
                        currentParent = prev;
                    }
                }

                len[current] = currentBestLength;
                parent[current] = currentParent;

                if (currentBestLength > maxLen)
                {
                    maxLen = currentBestLength;
                    lastIndex = current;
                }
            }

            var stack = new Stack<string>();

            while (lastIndex != -1)
            {
                var str = words[lastIndex];
                stack.Push(str);
                lastIndex = parent[lastIndex];
            }

            Console.WriteLine(string.Join(" ", stack));
        }
    }
}