using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //First, we need to read n from the console. //3

            int[] numbers = new int[n];//Create an array of integer with n size. // { 0 0 0 } 

            for (int i = 0; i < n; i++)//Read n numbers using for loop.
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;//Set number to the corresponding index.
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");//Print the array in reversed order.
            }
        }
    }
}
