using System;

namespace simpleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 123;

            int a = number / 100;
            int b = ((number / 10) % 10);
            int c = number % 10;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
