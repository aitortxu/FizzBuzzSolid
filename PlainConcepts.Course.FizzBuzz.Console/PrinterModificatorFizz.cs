using System;

namespace PlainConcepts.Course.FizzBuzz.Console
{
    public class PrinterModificatorFizz : IPrinterModificator
    {
        public string Print(int number)
        {
            var result = "";

            if (number % 3 == 0)
            {
                result = "Fizz";
            }
            return result;
        }
    }
}