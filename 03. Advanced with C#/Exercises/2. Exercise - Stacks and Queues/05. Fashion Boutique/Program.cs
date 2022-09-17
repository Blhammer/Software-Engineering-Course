using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int capacityOfARack = int.Parse(Console.ReadLine());

            Stack<int> sequenceOfTheClothesInTheBox = new Stack<int>(input);

            int racks = 0;
            int currentSum = 0;

            while (sequenceOfTheClothesInTheBox.Count != 0)
            {
                if (capacityOfARack == 0)
                {
                    break;
                }

                int currentClothes = sequenceOfTheClothesInTheBox.Peek();
                int currentClothesSum = currentSum + currentClothes;

                if (currentClothesSum < capacityOfARack)
                {
                    currentSum += currentClothes;
                    sequenceOfTheClothesInTheBox.Pop();
                    
                    if (sequenceOfTheClothesInTheBox.Count == 0)
                    {
                        racks++;
                    }
                }
                else if (currentClothesSum > capacityOfARack)
                {
                    currentSum = 0;
                    racks++;
                }
                else if (currentClothesSum == capacityOfARack)
                {
                    if (sequenceOfTheClothesInTheBox.Count != 0)
                    {
                        sequenceOfTheClothesInTheBox.Pop();
                        currentSum = 0;
                        racks++;
                    }
                }
            }

            Console.WriteLine(racks);
        }
    }
}
