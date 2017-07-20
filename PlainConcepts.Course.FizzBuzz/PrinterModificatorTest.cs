using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace PlainConcepts.Course.FizzBuzz
{
    using NUnit.Framework;
    using PlainConcepts.Course.FizzBuzz.Console;
    using System.Collections.Generic;

    [TestFixture]
    public class PrinterModificatorTest
    {
        private Printer printer;
       
        [Test]
        [TestCaseSource("SomePrinterModificators")]
        public void ShouldPrintTheWord_IfTheNumberIsMultipleOfTheNumber(Dictionary<int, string> modificatorsDictionary, int number, string expectedWord)
        {
            printer = new Printer(modificatorsDictionary);
            var result = printer.Print(number);
            result.Should().Be(expectedWord);
        }

        public static IEnumerable<TestCaseData> SomePrinterModificators
        {
            get
            {
                yield return new TestCaseData(new Dictionary<int, string>() { { 3, "Fizz" }, { 5, "Buzz" } }, 3, "Fizz");                
                yield return new TestCaseData(new Dictionary<int, string>() { { 3, "Fizz" }, { 5, "Buzz" } }, 15, "FizzBuzz");                
                yield return new TestCaseData(new Dictionary<int, string>() { { 3, "Fizz" }, { 5, "Buzz" } }, 10, "Buzz");                
                yield return new TestCaseData(new Dictionary<int, string>() { { 3, "Fizz" }, { 5, "Buzz" }, { 7, "Cua" } }, 105, "FizzBuzzCua");                
            }
        }

    }
}
