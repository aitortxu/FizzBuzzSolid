using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace PlainConcepts.Course.FizzBuzz
{
    [TestClass]
    public class FizzBuzzer
    {
        [TestMethod]
        public void ShouldPrintTheNumber_IfTheNumberDoesntFitAnyCondition()
        {
            var printer = new Printer();
            var result = printer.Print(1);
            result.Should().Be("1");
        }

        [TestMethod]
        public void ShouldPrintFizz_IfTheNumberIsMultipleOfThree()
        {
            var printer = new Printer();
            var result = printer.Print(3);
            result.Should().Be("Fizz");
        }
        [TestMethod]
        public void ShouldPrintBuzz_IfTheNumberIsMultipleOfFive()
        {
            var printer = new Printer();
            var result = printer.Print(5);
            result.Should().Be("Buzz");
        }
        [TestMethod]
        public void ShouldPrintFizzBuzz_IfTheNumberIsMultipleOfThreeAndFive()
        {
            var printer = new Printer();
            var result = printer.Print(15);
            result.Should().Be("FizzBuzz");
        }
    }
}
