using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace PlainConcepts.Course.FizzBuzz
{
    using Moq;
    using NUnit.Framework;
    using PlainConcepts.Course.FizzBuzz.Console;

    [TestFixture]
    public class IteratorTests
    {
        [Test]
        public void ShouldIterateAHundredTimes()
        {
            var printerMock = new Mock<IPrinter>();
            var iterator = new Iterator(printerMock.Object);
            iterator.Iterate();

            printerMock.Verify(printer => printer.Print(It.IsAny<int>()), Times.Exactly(100));
        }
    }
}
