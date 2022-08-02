using System;

namespace _8._ToysStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceJourney = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totalAmount = puzzles * 2.6 + talkingDolls * 3 + teddyBears * 4.1 + minions * 8.2 + trucks * 2;

            if ((puzzles + talkingDolls + teddyBears + minions + trucks) >= 50)
            {
                totalAmount = totalAmount - totalAmount * 25 / 100;
            }

            totalAmount = totalAmount - totalAmount * 10 / 100;

            if (totalAmount < priceJourney)
            {
                Console.WriteLine($"Not enough money! {(priceJourney - totalAmount):f2} lv needed.");
            }
            else
            {
                Console.WriteLine($"Yes! {(totalAmount - priceJourney):f2} lv left.");
            }
        }
    }
}
