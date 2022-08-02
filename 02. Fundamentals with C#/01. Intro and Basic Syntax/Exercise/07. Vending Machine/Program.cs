using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();
            double addedCoins = 0;
            double priceOfProduct = 0;

            while (coins != "Start")
            {
                double currentCoins = double.Parse(coins);
                bool isValidMoney = currentCoins == 0.1 ||
                                                 currentCoins == 0.2 ||
                                                 currentCoins == 0.5 ||
                                                 currentCoins == 1 ||
                                                 currentCoins == 2;
                if (isValidMoney)
                {
                    addedCoins += currentCoins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                coins = Console.ReadLine();
            }
            
            if (coins == "Start")
            {
                string product = Console.ReadLine();

                while (product != "End")
                {
                    if (product == "Nuts")
                    {
                        priceOfProduct = 2.0;
                    }
                    else if (product == "Water")
                    {
                        priceOfProduct = 0.7;
                    }
                    else if (product == "Crisps")
                    {
                        priceOfProduct = 1.5;
                    }
                    else if (product == "Soda")
                    {
                        priceOfProduct = 0.8;
                    }
                    else if (product == "Coke")
                    {
                        priceOfProduct = 1.0;
                    }
                    else 
                    {
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                    }

                    addedCoins -= priceOfProduct;

                    if (addedCoins < 0) 
                    {
                        addedCoins += priceOfProduct;
                        Console.WriteLine("Sorry, not enough money");
                        product = Console.ReadLine();
                        continue;
                    }
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    product = Console.ReadLine();
                }
            } 
            Console.WriteLine($"Change: {addedCoins:f2}");
        }
    }
}
