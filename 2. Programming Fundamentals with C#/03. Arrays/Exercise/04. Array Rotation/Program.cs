using System;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                 .Split(" ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string ellementToRotate = arr[0];

                for (int  j = 1; j < arr.Length; j++)
                {
                    string currentEllement = arr[j];
                    arr[j - 1] = currentEllement;
                }
                arr[arr.Length - 1] = ellementToRotate;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
