using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldDemo;
using PolymorphieDemo;

namespace TestPolymorphie
{
    [TestClass]
    class ShowKapselnTests
    {
        [TestMethod]
        public void DemoKapselung()
        {
            var mock = new ShowKapselung();
            var child = new Child();
           
        }
    }

}
