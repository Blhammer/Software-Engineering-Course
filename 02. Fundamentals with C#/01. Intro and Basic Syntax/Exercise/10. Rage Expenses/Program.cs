using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double money = headSetPrice * (lostGamesCount / 2);
            money += mousePrice * (lostGamesCount / 3);
            money += keyboardPrice * (lostGamesCount / 6);
            money += displayPrice * (lostGamesCount / 12);

            Console.WriteLine($"Rage expenses: {money:f2} lv.");
        }
    }
}
