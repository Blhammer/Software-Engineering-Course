using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate how many courses will be needed
            //to elevate persons by using an elevator of capacity of persons.
            //The input holds two lines: the number of people and the capacity of the elevator.

            int countOfPeople = int.Parse(Console.ReadLine());
            int capacityOfTheElevator = int.Parse(Console.ReadLine());
            
            int courses = (int)Math.Ceiling((double)countOfPeople / capacityOfTheElevator);

            Console.WriteLine(courses);
        }
    }
}
