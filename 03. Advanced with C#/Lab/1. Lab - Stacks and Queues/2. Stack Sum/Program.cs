using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            string[] inputCommands = Console.ReadLine().ToLower().Split(' ').ToArray();

            while(inputCommands[0] != "end")
            {
                string firstRule = inputCommands[1];
                int firstNumber = int.Parse(firstRule);

                if (inputCommands[0] == "add")
                {
                    string secondRule = inputCommands[2];
                    int secondNumber = int.Parse(secondRule);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (inputCommands[0] == "remove")
                {
                    if (stack.Count > firstNumber)
                    {
                        for (int i = 0; i < firstNumber; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                inputCommands = Console.ReadLine().ToLower().Split(' ');
            }
            
            Console.WriteLine($"Sum: {stack.Sum()}");
            

            /*
            //Second way
            string numbersAsString = Console.ReadLine();

            Stack<int> numbers = new Stack<int>();
            string[] numbersList = numbersAsString.Split(' ');
            foreach (var number in numbersList)
            {
                numbers.Push(int.Parse(number));
            }

            while (true)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(' ');
                string command = lineParts[0].ToLower();
                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {
                    numbers.Push(int.Parse(lineParts[1]));
                    numbers.Push(int.Parse(lineParts[2]));
                }
                else if (command == "remove")
                {
                    var numberOfElementsToRemove = int.Parse(lineParts[2]);

                    if (numberOfElementsToRemove <= numbers.Count)
                    {
                        for (int i = 0; i < numberOfElementsToRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

                //Console.WriteLine($"Sum: {numbers.Sum()}");
                int sum = 0;
                while (numbers.Count > 0)
                {
                    int number = numbers.Pop();
                    sum += number;
                }

                Console.WriteLine(sum); ;
            }
            */
        }
    }
}
