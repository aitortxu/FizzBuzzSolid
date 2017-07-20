using System;
using System.Linq;
using System.Configuration;
using System.Collections.Generic;

namespace PlainConcepts.Course.FizzBuzz.Console
{
    using Console = System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            var printerConfigurationsProp = ConfigurationManager.AppSettings.Get("Settings:PrinterConfigurations");

            var configurationReader = new ConfigurationReader();
            var printerConfigurations = configurationReader.decodePrinterConfiguration(printerConfigurationsProp);
                        
            var iterator = new Iterator(new Printer(printerConfigurations));

            iterator.Iterate();

            do { } while (System.Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

    }
}
