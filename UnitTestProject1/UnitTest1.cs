using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(say2EatTests.Program.AnalizeInput("i want to order a pizza with black olives"), "Your pizza with black olives,is on the way");
        }
    }
}
