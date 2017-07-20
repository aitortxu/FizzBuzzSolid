using System;

namespace PlainConcepts.Course.FizzBuzz.Console
{
    public class PrinterModificatorCua : IPrinterModificator
    {
        public string Print(int number)
        {
            var result = "";

            if (number % 7 == 0)
            {
                result = "Cua";
            }
            return result;
        }
    }
}