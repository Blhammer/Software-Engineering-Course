using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());

            int[][] jaggedMatrix = new int[matrixRows][];

            for (int i = 0; i < matrixRows; i++)
            {
                jaggedMatrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string commandsInput = Console.ReadLine();

            while (commandsInput != "END")
            {
                string[] commands = commandsInput.Split();

                string command = commands[0];

                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                if (row < jaggedMatrix.Length && col < matrixRows && row >= 0 && col >= 0)
                {
                    if (command == "Add")
                    {
                        jaggedMatrix[row][col] += value;
                    }
                    else if (command == "Subtract")
                    {
                        jaggedMatrix[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                commandsInput = Console.ReadLine();
            }

            foreach (int[] rowElement in jaggedMatrix)
            {
                Console.WriteLine(String.Join(" ", rowElement));
            }
        }
    }
}
