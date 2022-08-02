using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfSabre = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double lightsabersTotal = (countOfStudents + Math.Ceiling(countOfStudents * 0.1)) * priceOfSabre;
            double robesTotal = countOfStudents * priceOfRobe;
            double beltsTotal = 0;
            if (countOfStudents >= 10)
            {
                beltsTotal = (countOfStudents - countOfStudents / 6) * priceOfBelt;//countOfStudent - 1/6 countOfStudents => 2 - 2/6, 5 - 1/5;   
            }
            else
            {
                beltsTotal = countOfStudents * priceOfBelt;
            }

            double totalPrice = beltsTotal + robesTotal + lightsabersTotal;

            if (money - totalPrice >= 0)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice - money):f2}lv more.");
            }
        }
    }
}
