using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PlainConcepts.Course.FizzBuzz.Console
{
    public class Printer : IPrinter
    {
        private ICollection<IPrinterModificator> printerModificators;

        public Printer(ICollection<IPrinterModificator> printerModificators)
        {
            this.printerModificators = printerModificators;
        }

        public Printer(Dictionary<int, string> modificatorsDictionary)
        {
            printerModificators = new Collection<IPrinterModificator>();
            foreach (var item in modificatorsDictionary)
            {
                printerModificators.Add(new PrinterModificator(item.Key, item.Value));
            }
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
