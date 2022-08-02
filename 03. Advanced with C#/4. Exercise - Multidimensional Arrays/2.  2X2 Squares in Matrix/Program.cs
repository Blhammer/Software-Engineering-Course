using System;
using System.Linq;

namespace _2.__2X2_Squares_in_Matrix
{
    class Program
    {
         static void Main(string[] args)
         {
             int[] inputArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
         
             int rowSize = inputArgs[0];
             int colSize = inputArgs[1];
         
             string[][] jaggedArray = new string[rowSize][];
         
             for (int row = 0; row < rowSize; row++)
             {
                 string[] charArr = Console.ReadLine().Split(' ').ToArray();
         
                 jaggedArray[row] = charArr;
             }
         
             int counter = 0;
         
             for (int row = 0; row < rowSize - 1; row++)
             {
                 for (int col = 0; col < colSize - 1; col++)
                 {
                     string topLeft = jaggedArray[row][col];
                     string topRight = jaggedArray[row][col + 1];
                     string bottomLeft = jaggedArray[row + 1][col];
                     string bottomRight = jaggedArray[row + 1][col + 1];
         
                     if (topLeft == topRight && topRight == bottomLeft && bottomLeft == bottomRight)
                     {
                         counter++;
                     }
                 }
             }
         
             Console.WriteLine(counter);
         }
    }
}
