using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumbers = int.Parse(Console.ReadLine());
            int endNumbers = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = startNumbers; i <= endNumbers; i++)
            {
                Console.Write($"{i + " "}");
                counter += i;
            }
            Console.WriteLine();
            Console.Write($"Sum: {counter}");
        }
    }
}
