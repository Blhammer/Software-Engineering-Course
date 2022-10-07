using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Road_Trip
{
    public class Program
    {
        public static void Main()
        {
            var values = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            var weights = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            var maxCapacity = int.Parse(Console.ReadLine());

            var table = new int[values.Length + 1, maxCapacity + 1];

            for (int row = 1; row < table.GetLength(0); row++)
            {
                var itemValue = values[row - 1];
                var itemWeight = weights[row - 1];

                for (int capacity = 0; capacity < table.GetLength(1); capacity++)
                {
                    var skipItemValue = table[row - 1, capacity];

                    if (itemWeight > capacity)
                    {
                        table[row, capacity] = skipItemValue;
                        continue;
                    }

                    var includeItemValue = itemValue + table[row - 1, capacity - itemWeight];

                    table[row, capacity] = Math.Max(skipItemValue, includeItemValue);
                }
            }

            Console.WriteLine($"Maximum value: {table[values.Length, maxCapacity]}");
        }
    }
}