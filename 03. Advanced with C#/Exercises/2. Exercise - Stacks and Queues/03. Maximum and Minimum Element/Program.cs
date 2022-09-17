using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Stack<int> sequence = new Stack<int>();

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                int[] commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                string command = commands[0].ToString();

                switch (command)
                {
                    case "1":
                        int token = commands[1];
                        sequence.Push(token);
                        break;
                    case "2":
                        if (sequence.Count > 0)
                        {
                            sequence.Pop();
                        }
                        break;
                    case "3":
                        if (sequence.Count > 0)
                        {
                            Console.WriteLine(sequence.Max());
                        }
                        break;
                    case "4":
                        if (sequence.Count > 0)
                        {
                            Console.WriteLine(sequence.Min());
                        }
                        break;
                    default:
                        break;
                }
            }

            int index = 1;
            
            foreach (var currentNumber in sequence)
            {
                //remove the last comma of the sequence
                if (sequence.Count == index)
                {
                    Console.Write(currentNumber);
                }
                else
                {
                    Console.Write($"{currentNumber}, ");
                    index++;
                }
            }

            Console.WriteLine();
        }
    }
}
