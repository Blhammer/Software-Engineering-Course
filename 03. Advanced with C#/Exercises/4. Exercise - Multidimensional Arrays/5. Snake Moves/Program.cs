using System;
using System.Linq;
using System.Text;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            StringBuilder snake = new StringBuilder(Console.ReadLine());
            
            string snakeTemp = snake.ToString();
            
            char[,] snakePath = new char[matrixSizes[0], matrixSizes[1]];
            
            for (int row = 0; row < matrixSizes[0]; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrixSizes[1]; col++)
                    {
                        if (snake.Length == 0)
                        {
                            snake.Append(snakeTemp);
                        }
                        snakePath[row, col] = snake[0];
                        snake.Remove(0, 1);
                    }
                }
                else
                {
                    for (int col = matrixSizes[1] - 1; col >= 0; col--)
                    {
                        if (snake.Length == 0)
                        {
                            snake.Append(snakeTemp);
                        }
                        snakePath[row, col] = snake[0];
                        snake.Remove(0, 1);
                    }
                }
            }

            for (int row = 0; row < matrixSizes[0]; row++)
            {
                for (int col = 0; col < matrixSizes[1]; col++)
                {
                    Console.Write(snakePath[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
