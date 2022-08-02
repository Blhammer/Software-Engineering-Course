using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine(); 

            int sum = 0; 

            for (int i = 0; i < number.Length; i++)
            {
                int currentNumber = (int)char.GetNumericValue(number[i]);
                sum += currentNumber;
            }

            Console.WriteLine($"The sum of the digits is {sum}");
        }
    }
}
