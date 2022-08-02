using System;
using System.Numerics;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 1; i <= counter; i++)
            {
                decimal numbers = decimal.Parse(Console.ReadLine());
                total += numbers;
            }
            Console.WriteLine(total);
        }
    }
}
