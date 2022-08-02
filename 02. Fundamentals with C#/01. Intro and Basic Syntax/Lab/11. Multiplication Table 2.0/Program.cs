using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int rowNumber = 0;

            for (int i = 1; i <= 10; i++)
            {
                rowNumber++;
                int sumWithMultiplier = number * multiplier;

                if (multiplier > 10)
                {
                    Console.WriteLine($"{number} X {multiplier} = {sumWithMultiplier}");
                    break;
                }
                else 
                {
                    int specMultiplierNumber = number * multiplier;
                    Console.WriteLine($"{number} X {multiplier} = {specMultiplierNumber}");
                    if (multiplier == 10)
                    {
                        break;
                    }
                    multiplier++;
                }
            }
        }
    }
}
