using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingleTon;
namespace UnitTestProject
{
    [TestClass]
    public class SingleToneUnitTest
    {
        [TestMethod]
        public void InstanceTest()
        {
            Singleton ton =  Singleton.Getinstance;
            Assert.IsNotNull(ton);
        }
        [TestMethod]
        public void LogContentTest()
        {
            Singleton ton = Singleton.Getinstance;
            string response =  ton.LogContent("hello pramod");
            Assert.IsNotNull(response);
        }
    }
}
