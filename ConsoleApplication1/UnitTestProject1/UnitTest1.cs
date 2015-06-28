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
            bool b = Program.CheckIfDividable(60, 4);
            Assert.IsTrue(b);

        }
        [TestMethod]
        public void TestMethod2()
        {
            long b = Program.Smallestmultiple(20);
            long testValue = 232792560;
            Assert.AreEqual(b, testValue);
        }

    }
}
