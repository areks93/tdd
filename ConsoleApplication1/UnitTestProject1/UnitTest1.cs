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
            Program p = new Program();
            bool b = Program.CheckIfDividable(60, 4);
            Assert.IsTrue(b);

        }
    }
}
