using System;

namespace PlainConcepts.Course.FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            for (var i = 1; i < 101; i++)
            {
                System.Console.WriteLine(printer.Print(i));
            }

            
            do{} while (System.Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
