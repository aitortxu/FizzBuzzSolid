namespace PlainConcepts.Course.FizzBuzz.Console
{
    public class Iterator
    {
        private IPrinter printer;

        public Iterator(IPrinter printer)
        {
            this.printer = printer;
        }
        public void Iterate()
        {            
            for (var i = 1; i < 101; i++)
            {
                System.Console.WriteLine(printer.Print(i));
            }
        }
    }
}