using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfFood = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(input);

            int biggestOrder = orders.Max();

            while (amountOfFood > 0 && orders.Count != 0)
            {
                int currentOrder = orders.Peek();

                if (currentOrder <= amountOfFood)
                {
                    orders.Dequeue();
                    amountOfFood -= currentOrder;
                }
                else
                {
                    break;
                }
            }
            
            Console.WriteLine(biggestOrder);

            if (amountOfFood >= 0 && orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");

                foreach (var order in orders)
                {
                    Console.Write(order + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
