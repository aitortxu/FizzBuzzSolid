using System;

namespace PlainConcepts.Course.FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var iterator = new Iterator();
            iterator.Iterate();

            do{} while (System.Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

    }
}
