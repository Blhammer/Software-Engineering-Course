using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string customer = Console.ReadLine();
            Queue<string> customerList = new Queue<string>();

            while (customer != "End")
            {
                if (customer == "Paid")
                {
                    foreach (var name in customerList)
                    {
                        Console.WriteLine(name);
                    }
                    customerList.Clear();
                    customer = Console.ReadLine();
                    continue;
                }
                customerList.Enqueue(customer);

                customer = Console.ReadLine();
            }

            Console.WriteLine($"{customerList.Count()} people remaining.");
        }
    }
}
