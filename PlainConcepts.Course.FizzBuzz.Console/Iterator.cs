namespace PlainConcepts.Course.FizzBuzz.Console
{
    public class Iterator
    {
        public void Iterate()
        {
            var printer = new Printer();
            for (var i = 1; i < 101; i++)
            {
                System.Console.WriteLine(printer.Print(i));
            }
        }
    }
}