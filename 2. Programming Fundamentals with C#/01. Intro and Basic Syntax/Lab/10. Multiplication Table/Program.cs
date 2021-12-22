using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int rowNumber = 0;

            for (int i = 1; i <= 10; i++)
            {
                rowNumber++;
                int sum = number * rowNumber;
                Console.WriteLine($"{number} X {rowNumber} = {sum}"); 
            }
        }
    }
}
