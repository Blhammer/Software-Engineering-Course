using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> trucks = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] fuelDistance = Console.ReadLine().Split().Select(int.Parse).ToArray();

                trucks.Enqueue(fuelDistance);
            }

            int startIndex = 0;

            while (true)
            {
                int currentPetrol = 0;

                foreach (var tokens in trucks)
                {
                    int petrol = tokens[0];
                    int distance = tokens[1];

                    currentPetrol += petrol;
                    currentPetrol -= distance;

                    if (currentPetrol < 0)
                    {
                        int[] element = trucks.Dequeue();
                        trucks.Enqueue(element);
                        startIndex++;
                        break;
                    }
                }

                if (currentPetrol >= 0)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}
