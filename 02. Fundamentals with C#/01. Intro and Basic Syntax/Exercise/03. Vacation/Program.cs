using System;
using System.Text;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfTicket = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double total = 0;
            double ticketAfter15Percent = 0;

            switch (typeOfTicket)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    break;
                default:
                    break;
            }
            
            if (typeOfTicket == "Students" && people >= 30)
            {
                total = price * people;
                ticketAfter15Percent = total * 0.85;
                Console.WriteLine($"Total price: {ticketAfter15Percent:f2}");
            }
            else if (typeOfTicket == "Business" && people >= 100)
            {
                double group = people - 10;
                total = price * group;
                Console.WriteLine($"Total price: {total:f2}");
            }
            else if (typeOfTicket == "Regular" && people >= 10 && people <= 20)
            {
                total = price * people * 0.95;
                Console.WriteLine($"Total price: {total:f2}");
            }
            else
            {
                total = price * people;
                Console.WriteLine($"Total price: {total:f2}");
            }
        }
    }
}
