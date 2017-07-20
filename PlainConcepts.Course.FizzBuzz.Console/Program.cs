using System;
using System.Collections.ObjectModel;

namespace PlainConcepts.Course.FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var iterator = new Iterator(new Printer(new Collection<IPrinterModificator>() {
                new PrinterModificatorFizz(),
                new PrinterModificatorBuzz(),
                new PrinterModificatorCua()
            }));
            iterator.Iterate();

            do{} while (System.Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

    }
}
