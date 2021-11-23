using System;

namespace Commission
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            int percentageCommission = int.Parse(Console.ReadLine());
            double pricePerMonth = double.Parse(Console.ReadLine());

            int halfMonths = months / 2;
            int otherMonths = months - halfMonths;

            double monthPrice = ((halfMonths * pricePerMonth) + (otherMonths * pricePerMonth * 0.8));
            double price = (monthPrice * percentageCommission / 100) + monthPrice;
            Console.WriteLine($"Total: {price:f2}");
        }
    }
}
