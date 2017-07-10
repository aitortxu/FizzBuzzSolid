namespace PlainConcepts.Course.FizzBuzz.Console
{
    public class Printer
    {
        public string Print(int number)
        {
            var result = "";

            if (number%3 == 0)
            {
                result =  "Fizz";
            }
            if (number % 5 == 0)
            {
                result = result + "Buzz";
            }
            if (number % 7 == 0)
            {
                result = result + "Cua";
            }
            if (result == "")
            {
                result = number.ToString();
            }
            return result;
        }
    }
}
