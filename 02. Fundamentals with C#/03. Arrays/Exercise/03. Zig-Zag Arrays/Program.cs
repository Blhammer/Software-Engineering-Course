using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            string[] firstArray = new string[numbers];
            string[] secondArray = new string[numbers];

            for (int i = 0; i < numbers; i++)
            {
                string[] currentArray = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                string indexZero = currentArray[0];
                string indexOne = currentArray[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = indexZero;
                    secondArray[i] = indexOne;
                }
                else if (i % 2 == 1)
                {
                    firstArray[i] = indexOne;
                    secondArray[i] = indexZero;
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
