using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfMonths = int.Parse(Console.ReadLine());
            double personalPayments = double.Parse(Console.ReadLine());

            double priceForNeed = budget * 30 / 100;
            double savingsPerMonth = budget - (personalPayments + priceForNeed);
            double savedMoneyForCountMonths = countOfMonths * savingsPerMonth;
            double procentOfBudget = savingsPerMonth / budget * 100;

            Console.WriteLine($"She can save {procentOfBudget:f2}%");
            Console.WriteLine($"{savedMoneyForCountMonths:f2}");
        }
    }
}
