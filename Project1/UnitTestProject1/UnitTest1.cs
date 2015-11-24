using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            var expected = 6;
            var actual = Class1.Add(1, 5);
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void TestSub()
        //{
        //    var expected = -4;
        //    var actual = Class1.Sub(1, 5);
        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void TestMul()
        {
            var expected = 20;
            var actual = Class1.Mul(4, 5);
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void TestDiv()
        //{
        //    var expected = 4;
        //    var actual = Class1.Div(20, 5);
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
