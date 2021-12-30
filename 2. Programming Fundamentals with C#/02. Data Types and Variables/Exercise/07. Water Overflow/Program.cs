using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int liter = 0;
            int literSum = 0;

            for (int i = 0; i < quantity; i++)
            {
                liter = int.Parse(Console.ReadLine());
                literSum += liter;

                if (literSum > 255)
                {
                    literSum -= liter;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(literSum);
        }
    }
}
