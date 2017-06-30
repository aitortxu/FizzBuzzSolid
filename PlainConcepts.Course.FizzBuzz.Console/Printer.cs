namespace PlainConcepts.Course.FizzBuzz
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
            if (result == "")
            {
                result = number.ToString();
            }
            return result;
        }
    }
}
