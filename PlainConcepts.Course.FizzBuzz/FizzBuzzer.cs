using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace PlainConcepts.Course.FizzBuzz
{
    using NUnit.Framework;
    using PlainConcepts.Course.FizzBuzz.Console;

    [TestFixture]
    public class FizzBuzzer
    {
        [Test]
        public void ShouldPrintTheNumber_IfTheNumberDoesntFitAnyCondition()
        {
            var printer = new Printer();
            var result = printer.Print(1);
            result.Should().Be("1");
        }

        [Test]
        [TestCase(3)]
        [TestCase(9)]
        [TestCase(21)]
        [TestCase(33)]
        public void ShouldPrintFizz_IfTheNumberIsMultipleOfThree(int number)
        {
            var printer = new Printer();
            var result = printer.Print(number);
            result.Should().Be("Fizz");
        }
        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(25)]
        [TestCase(35)]
        public void ShouldPrintBuzz_IfTheNumberIsMultipleOfFive(int number)
        {
            var printer = new Printer();
            var result = printer.Print(number);
            result.Should().Be("Buzz");
        }
        [Test]
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        [TestCase(60)]
        public void ShouldPrintFizzBuzz_IfTheNumberIsMultipleOfThreeAndFive(int number)
        {
            var printer = new Printer();
            var result = printer.Print(number);
            result.Should().Be("FizzBuzz");
        }
    }
}
