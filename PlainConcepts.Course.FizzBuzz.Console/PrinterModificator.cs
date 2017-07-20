using System;

namespace PlainConcepts.Course.FizzBuzz.Console
{
    public class PrinterModificator : IPrinterModificator
    {
        private int specialCharacter;
        private string wordToInsert;

        public PrinterModificator(int specialCharacter, string wordToInsert)
        {
            this.specialCharacter = specialCharacter;
            this.wordToInsert = wordToInsert;
        }
        public string Print(int number)
        {
            var result = "";

            if (number % specialCharacter == 0)
            {
                result = wordToInsert;
            }
            return result;
        }
    }
}