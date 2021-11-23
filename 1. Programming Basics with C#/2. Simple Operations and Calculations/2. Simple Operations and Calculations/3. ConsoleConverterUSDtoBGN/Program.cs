using System;

namespace consoleConverterUSDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());

            double bgn = usd * 1.69421;

            Console.WriteLine($"{bgn:f2}");
        }
    }
}
