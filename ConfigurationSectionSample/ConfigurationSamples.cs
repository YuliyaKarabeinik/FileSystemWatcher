using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using ConfigurationSectionSample.Configuration;

namespace ConfigurationSectionSample
{
    [TestClass]
    public class ConfigurationSamples
    {
        [TestMethod]
        public void ReadCustomSection()
        {
            var s = (CustomConfigurationSection)
                ConfigurationManager.GetSection("simpleSection");

            Console.WriteLine("{0} {1} - {2}",
                s.ApplicationName,
                s.WorkTime.StartTime.ToLongTimeString(),
                (s.WorkTime.StartTime + s.WorkTime.Duration).ToLongTimeString());

            foreach (FileElement file in s.Files)
            {
                Console.WriteLine("{0} - {1}", file.FileName, file.FileSize);
            }
        }

        [TestMethod]
        public void ReadPredefinedSections()
        {
            Console.WriteLine(
                ConfigurationManager.ConnectionStrings["myDB"].ConnectionString);
            Console.WriteLine(
                ConfigurationManager.AppSettings["Key2"]);
        }

        [TestMethod]
        public void Read()
        {
            var s = (CustomConfigurationSection)
                ConfigurationManager.GetSection("simpleSection");
            Console.WriteLine($"{s.ApplicationName}\n{s.Culture}\n{s.Culture.Name}");


            Console.WriteLine("{0} {1} - {2}",
                s.ApplicationName,
                s.WorkTime.StartTime.ToLongTimeString(),
                (s.WorkTime.StartTime + s.WorkTime.Duration).ToLongTimeString());

            foreach (FolderElement folder in s.Folders)
            {
                Console.WriteLine($"{folder.FolderPath}");
            }
        }
    }
}
