using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int primaryDiagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            for (int currentElementOfPrimaryDiagonal = 0; currentElementOfPrimaryDiagonal < matrix.GetLength(0); currentElementOfPrimaryDiagonal++)
            {
                primaryDiagonalSum += matrix[currentElementOfPrimaryDiagonal, currentElementOfPrimaryDiagonal];
            }

            Console.WriteLine(primaryDiagonalSum);
        }
    }
}
