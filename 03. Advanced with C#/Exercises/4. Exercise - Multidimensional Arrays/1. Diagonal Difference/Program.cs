using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix =  int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeMatrix, sizeMatrix];

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryDiagonalSum += matrix[i, i];
            }

            int counter = matrix.GetLength(1) - 1;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                secondaryDiagonalSum += matrix[i, counter];
                counter--;
            }

            int absSum = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

            Console.WriteLine(absSum);
        }
    }
}
