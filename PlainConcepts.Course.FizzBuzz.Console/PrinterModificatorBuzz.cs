using System;

namespace PlainConcepts.Course.FizzBuzz.Console
{
    public class PrinterModificatorBuzz : IPrinterModificator
    {
        public string Print(int number)
        {
            var result = "";

            if (number % 5 == 0)
            {
                result = "Buzz";
            }
            return result;
        }
    }
}