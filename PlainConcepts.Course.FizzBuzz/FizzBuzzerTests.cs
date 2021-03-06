﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace PlainConcepts.Course.FizzBuzz
{
    using NUnit.Framework;
    using PlainConcepts.Course.FizzBuzz.Console;
    using System.Collections.ObjectModel;

    [TestFixture]
    public class FizzBuzzerTests
    {
        private Printer printer;

        public FizzBuzzerTests()
        {
            printer = new Printer(new Collection<IPrinterModificator>() {
                 new PrinterModificator(3, "Fizz"),
                new PrinterModificator(5, "Buzz"),
                new PrinterModificator(7, "Cua")
            });
        }
        [Test]
        public void ShouldPrintTheNumber_IfTheNumberDoesntFitAnyCondition()
        {
            var result = printer.Print(1);
            result.Should().Be("1");
        }

        [Test]
        [TestCase(3)]
        [TestCase(9)]
        [TestCase(24)]
        [TestCase(33)]
        public void ShouldPrintFizz_IfTheNumberIsMultipleOfThree(int number)
        {
            var result = printer.Print(number);
            result.Should().Be("Fizz");
        }
        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(25)]
        [TestCase(40)]
        public void ShouldPrintBuzz_IfTheNumberIsMultipleOfFive(int number)
        {
            var result = printer.Print(number);
            result.Should().Be("Buzz");
        }
        [Test]
        [TestCase(7)]
        [TestCase(14)]
        [TestCase(28)]
        [TestCase(49)]
        public void ShouldPrintCua_IfTheNumberIsMultipleOfSeven(int number)
        {
            var result = printer.Print(number);
            result.Should().Be("Cua");
        }
        [Test]
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        [TestCase(60)]
        public void ShouldPrintFizzBuzz_IfTheNumberIsMultipleOfThreeAndFive(int number)
        {
            var result = printer.Print(number);
            result.Should().Be("FizzBuzz");
        }

        [Test]
        [TestCase(21)]
        public void ShouldPrintFizzCua_IfTheNumberIsMultipleOfThreeAndSeven(int number)
        {
            var result = printer.Print(number);
            result.Should().Be("FizzCua");
        }

        [TestCase(105)]
        public void ShouldPrintFizzBuzzCua_IfTheNumberIsMultipleOfThreeAndFiveAndSeven(int number)
        {
            var result = printer.Print(number);
            result.Should().Be("FizzBuzzCua");
        }
    }
}
