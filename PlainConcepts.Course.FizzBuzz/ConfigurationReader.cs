using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlainConcepts.Course.FizzBuzz
{
    using System.Collections.Generic;

    using Moq;

    using NUnit.Framework;

    using PlainConcepts.Course.FizzBuzz.Console;

    [TestFixture]
    public class ConfigurationReaderTests
    {
        [Test]
        public void ShouldGenerateDictionaryFromString()
        {
            const string prop = "3|Fizz;5|Buzz;7|Cua";

            var configurationReader = new ConfigurationReader();
            var printerConfigurations = configurationReader.decodePrinterConfiguration(prop);

            printerConfigurations.Count.Should().Be(3);
            printerConfigurations[3].Should().Be("Fizz");
            printerConfigurations[5].Should().Be("Buzz");
            printerConfigurations[7].Should().Be("Cua");
        }
    }
}
