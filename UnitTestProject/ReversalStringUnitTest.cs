using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseString;

namespace UnitTestProject
{
    [TestClass]
    public class ReversalStringUnitTest
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            string response = ReversalString.Reversal("Hello");
            Assert.AreEqual(response, "olleH");
        }

        [TestMethod]
        public void Test()
        {
            string response = ReversalString.Reversal("olleH");
            Assert.AreEqual(response, "Hello");
        }
    }
}
