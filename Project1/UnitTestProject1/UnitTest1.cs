using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = 6;
            var actual = Class1.Add(1, 5);
            Assert.AreEqual(expected, actual);
        }
    }
}
