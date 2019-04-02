using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldDemo;
using PolymorphieDemo;

namespace TestPolymorphie
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ctor_test()
        {
            var mock = new ShowPolymorphie();
            Assert.IsNotNull(mock);
        }
        [TestMethod]
        public void testSum()
        {
            var mock = new ShowPolymorphie();
            var res = mock.Sum(2, 4);
            Assert.IsTrue(res == 6);

            var res2 = mock.Sum(2.5, 4.6);
            Assert.IsTrue(res2 == 7);
        }
    }
}
