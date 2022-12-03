using System;

namespace AuthorProblem
{
    [Author("Bob")]
    public class StartUp
    {
        [Author("Peter")]
        static void Main(string[] args)
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}
