using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            bool isBigger = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentInt = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int element = arr[j];

                    if (element >= currentInt)
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write(currentInt + " ");
                }

                isBigger = true;
            }
        }
    }
}
