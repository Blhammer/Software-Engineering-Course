using System;

namespace ValidPerson
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person validPerson = new Person("Bob", "Snake", 55);

            try
            {
                Person personWithoutLastName = new Person("Cristiano", string.Empty, 27);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Person personWithNegativeAge = new Person("George", "Bobby", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Person personWithAgeOver120 = new Person("Bob", "Bobby", 155);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Student randomStudent = new Student("Red", "mit.student@mit-student.com");
            }
            catch (InvalidPersonNameException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
