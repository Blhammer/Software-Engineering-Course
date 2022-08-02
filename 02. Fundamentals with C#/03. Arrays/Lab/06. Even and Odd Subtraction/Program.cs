using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int oddCounter = 0;
            int evenCounter = 0;
            int subtraction = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenCounter += numbers[i];
                }
                else
                {
                    oddCounter += numbers[i];
                }
            }
            subtraction = evenCounter - oddCounter;
            Console.WriteLine(subtraction);
        }
    }
}
