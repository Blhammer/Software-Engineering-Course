using System;

namespace priceOfDrinks
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiqQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            //rakiq's price is half of the whiskey's price
            //wine's price is 40% lower than the rakiq's price
            //beer's price is 80% lower than the rakiq's price
            double rakiqPrice = whiskeyPrice / 2;
            double winePrice = rakiqPrice - (0.4 * rakiqPrice);
            double beerprice = rakiqPrice - (0.8 * rakiqPrice);
            double allRakiqPrice = rakiqQuantity * rakiqPrice;
            double allWinePrice = wineQuantity * winePrice;
            double allBeerPrice = beerQuantity * beerprice;
            double allWhiskeyPrice = whiskeyQuantity * whiskeyPrice;
            double allPrice = allWhiskeyPrice + allRakiqPrice + allWinePrice + allBeerPrice;

            Console.WriteLine($"{allPrice:f2}");
        }
    }
}
