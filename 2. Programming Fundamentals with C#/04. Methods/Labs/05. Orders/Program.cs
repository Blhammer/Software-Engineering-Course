using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());
            double totalSum = 0;
            
            Sum(order, counter, totalSum);
        }

        static void Sum(string order, int counter,double totalSum)
        {
            double price = 0;

            switch (order)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
                default:
                    break;
            }

            totalSum = price * counter;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
