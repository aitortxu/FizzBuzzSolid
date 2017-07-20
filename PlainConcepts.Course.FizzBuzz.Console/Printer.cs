using System.Collections.Generic;

namespace PlainConcepts.Course.FizzBuzz.Console
{
    public class Printer : IPrinter
    {
        private ICollection<IPrinterModificator> printerModificators;

        public Printer(ICollection<IPrinterModificator> printerModificators)
        {
            this.printerModificators = printerModificators;
        }
        public string Print(int number)
        {
            var result = "";

            foreach (var printerModificator in printerModificators)
            {
                result = result + printerModificator.Print(number);
            }       
            
            if (result == "")
            {
                result = number.ToString();
            }
            return result;
        }
    }
}
