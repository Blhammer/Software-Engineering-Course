using System;

namespace _7._AreasOfDifferentGeomethicShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape == "square")
            {
                double length = double.Parse(Console.ReadLine());

                double area = length * length;

                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());

                double area = length * width;

                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                double area = Math.PI * radius * radius;

                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "triangle")
            {
                double length = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double area = (length * height) / 2;

                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
