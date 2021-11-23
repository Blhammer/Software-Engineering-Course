using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine($"Area = {area:f2}");
            Console.WriteLine($"Perimeter = {perimeter:f2}");
        }
    }
}
