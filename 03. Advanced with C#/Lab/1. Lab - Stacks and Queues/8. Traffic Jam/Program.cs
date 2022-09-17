using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsPassOnGreenLight = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                else if (line == "green")
                {
                    for (int i = 0; i < numberOfCarsPassOnGreenLight; i++)
                    {
                        if (cars.Count > 0)
                        {
                            var car = cars.Dequeue();
                            Console.WriteLine(car + " passed!");
                            passedCars++;
                        }
                    }
                }
                else
                {
                    var car = line;
                    cars.Enqueue(car);
                }
            }

            Console.WriteLine(passedCars + " cars passed the crossroads.");
        }
    }
}
