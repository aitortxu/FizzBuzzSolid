namespace PlainConcepts.Course.FizzBuzz.Console
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;

    public class ConfigurationReader
    {        

        public ConfigurationReader()
        {
        }

        public Dictionary<int, string> decodePrinterConfiguration(string printerConfigurationsProp)
        {
            var printerConfigurationsDic = new Dictionary<int, string>();
              var printerConfigurations = printerConfigurationsProp.Split(';');
            foreach (var printerConfigurationProp in printerConfigurations)
            {
                var printerConfiguration = printerConfigurationProp.Split('|');
                printerConfigurationsDic.Add(Int32.Parse(printerConfiguration[0]), printerConfiguration[1]);
            }
            return printerConfigurationsDic;
        }
    }
}