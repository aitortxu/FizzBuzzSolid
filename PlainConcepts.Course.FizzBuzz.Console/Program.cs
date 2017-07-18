using System;

namespace PlainConcepts.Course.FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var iterator = new Iterator(new Printer());
            iterator.Iterate();

            do{} while (System.Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

    }
}
