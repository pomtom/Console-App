using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumber;

namespace UnitTestProject
{
    [TestClass]
    public class PrimeNumberTest
    {
        [TestMethod]
        public void IsNotPrime()
        {
            int response = PrimeNumberClass.PrintPrimeNumber(72);
            Assert.AreEqual(response, 0);
        }

        [TestMethod]
        public void IsPrime()
        {
            int response = PrimeNumberClass.PrintPrimeNumber(89);
            Assert.AreEqual(response, 89);
        }
    }
}
