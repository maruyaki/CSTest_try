using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculation = new test.Console.Object.caluculation();
            int result = calculation.Add(3, 5);
            Assert.AreEqual(8, result);
        }
    }
}
