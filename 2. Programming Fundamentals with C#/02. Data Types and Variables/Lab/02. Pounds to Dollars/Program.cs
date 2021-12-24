using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());

            decimal exchange = 131;
            decimal exchanged = (exchange * money) / 100;

            Console.WriteLine($"{exchanged:f3}");
        }
    }
}
