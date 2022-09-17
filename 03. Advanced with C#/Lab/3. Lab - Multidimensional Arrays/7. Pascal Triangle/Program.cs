using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            long[][] jaggedMatrix = new long[number + 1][];

            for (int row = 0; row < number; row++)
            {
                jaggedMatrix[row] = new long[row + 1];
            }

            jaggedMatrix[0][0] = 1;

            for (int row = 0; row < number - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    jaggedMatrix[row + 1][col] += jaggedMatrix[row][col];
                    jaggedMatrix[row + 1][col + 1] += jaggedMatrix[row][col]; 
                }
            }

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write($"{jaggedMatrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
