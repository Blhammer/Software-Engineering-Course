using System;

namespace _09._HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            int countOfNights = int.Parse(Console.ReadLine());

            double priceApartment = 0;
            double priceStudio = 0;

            if (date == "May" || date == "October")
            {
                //apartment: 65 leva per night
                //Discount - more than 14 nights: 10%
                if (countOfNights > 14)
                {
                    priceApartment = (65 * 0.9) * countOfNights;
                }
                else
                {
                    priceApartment = 65 * countOfNights;
                }
                Console.WriteLine($"Apartment: {priceApartment:f2} lv.");

                //studio: 50 leva per night
                //Discount - more than 7 days: 5%
                //Discount - more than 14 days: 30%
                if (countOfNights > 7 && countOfNights < 14)
                {
                    priceStudio = (50 * 0.05) * countOfNights;
                    Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                }
                else if (countOfNights > 14)
                {
                    priceStudio = (50 * 0.7) * countOfNights;
                    Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                }
            }
            else if (date == "June" || date == "September")
            {
                //apartment: 68.70 leva per night
                //Discount - more than 14 nights: 10%
                if (countOfNights > 14)
                {
                    priceApartment = (68.70 * 0.9) * countOfNights;
                }
                else
                {
                    priceApartment = 68.70 * countOfNights;
                }
                Console.WriteLine($"Apartment: {priceApartment:f2}  lv.");

                //studio: 75.20 leva per night
                //Discount - more than 14 days: 20%
                if (countOfNights > 14)
                {
                    priceStudio = (75.20 * 0.8) * countOfNights;
                }
                else
                {
                    priceStudio = 75.20 * countOfNights;
                }
                Console.WriteLine($"Studio: {priceStudio:f2}  lv.");

            }
            else if (date == "July" || date == "August")
            {
                //apartment: 77 leva per night
                //Discount - more than 14 nights: 10%
                if (countOfNights > 14)
                {
                    priceApartment = (77 * 0.9) * countOfNights;
                }
                else
                {
                    priceApartment = 77 * countOfNights;
                }
                Console.WriteLine($"Apartment: {priceApartment:f2}  lv.");

                //studio: 76 leva per night
                priceStudio = 76 * countOfNights;
                Console.WriteLine($"Studio: {priceStudio:f2}  lv.");
            }
        }
    }
}
