using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            int oddNumbers = 1;

            for (int i = 1; i <= number; i++)
            {
                counter += oddNumbers;
                Console.WriteLine(oddNumbers);
                oddNumbers += 2;
            }
            Console.WriteLine($"Sum: {counter}");
        }
    }
}
