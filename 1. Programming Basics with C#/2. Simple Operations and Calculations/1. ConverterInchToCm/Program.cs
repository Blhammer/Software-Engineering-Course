using System;

namespace converterInchToCm
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double usrate = 1.79549;
            double bgn = usd * usrate;
            Console.WriteLine($"{bgn:f2}");
        }
    }
}
