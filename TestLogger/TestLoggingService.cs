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
        public void Init()
        {
            var logger = new LoggingService();
            logger.init();
            Assert.IsNotNull(logger.filePath);
        }

        [TestMethod]
        public void AppendLine()
        {
            var logger = new LoggingService();
            logger.init();
            var logCount = logger.list.Count;
            logger.LogLine("test");
            //Assert.IsTrue(logger.list[logCount].Value.Contains("test"));
            Assert.IsTrue(logger.list.Count == 1);
        }
        
        [TestMethod]
        public void DeleteLine()
        {
            var logger = new LoggingService();     
            logger.init();

            //append line
            var logCount = logger.list.Count;
            logger.LogLine("test");          

            //delete line
            logger.Delete_Log_At_Line(logCount);
            Assert.IsTrue(logger.list.Count==0);
        }
    }
}
