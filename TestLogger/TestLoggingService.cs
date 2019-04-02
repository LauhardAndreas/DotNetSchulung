using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldDemo;
using Logger;
using System.IO;

namespace TestLogger
{
    [TestClass]
    public class TestLoggingService
    {
        [TestMethod]
        public void ctor_test()
        {
            var logger = new LoggingService();
            //Hilfsklassen
            Assert.IsNotNull(logger);
        }

        [TestMethod]
        public void AppendMessagetoLogfile()
        {
            var path = @"C:\Users\alauhard\AppData\Roaming\MySageLogs\log.txt";
            if (File.Exists(path))
                File.Delete(path);
          
            var logger = new LoggingService();
            var date = DateTime.Now.ToString("MM/dd/yyyy");
            logger.logIt("AppendMessageFromTestLogger-"+ date);

            using (var sr = new StreamReader(path))
            {
                var logInhalt = sr.ReadToEnd();
                Assert.IsTrue(logInhalt.Contains("AppendMessageFromTestLogger-"), "Test Message nicht vorhanden");

            }
        }
    }
}
