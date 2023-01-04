using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string student = input[0];
                double grade = double.Parse(input[1]);

                if (students.ContainsKey(student))
                {
                    students[student].Add(grade);
                }
                else
                {
                    students.Add(student, new List<double>() { grade });
                }
            }

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {String.Join(" ", item.Value.Select(x => $"{x:f2}"))} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
