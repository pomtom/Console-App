using System;
using FactoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FactoryInvoiceUnitTest
    {
        [TestMethod]
        public void MonthlyInvoiceTest()
        {
            IInvoice invfact = FactoryInvoice.GetInvoiceInstance("monthly");
            string response = invfact.GenerateInvoice();
            Assert.IsNotNull(invfact);
            Assert.AreEqual(response, "monthly");
        }

        [TestMethod]
        public void QuarterlyInvoiceTest()
        {
            IInvoice invfact = FactoryInvoice.GetInvoiceInstance("quarterly");
            string response = invfact.GenerateInvoice();
            Assert.IsNotNull(invfact);
            Assert.AreEqual(response, "quarterly");
        }

        [TestMethod]
        public void YearlyInvoiceTest()
        {
            IInvoice invfact = FactoryInvoice.GetInvoiceInstance("yearly");
            string response = invfact.GenerateInvoice();
            Assert.IsNotNull(invfact);
            Assert.AreEqual(response, "yearly");
        }
    }
}
