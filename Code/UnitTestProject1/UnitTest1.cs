using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebApplication1.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddMethodTest()
        {
            int x = 10, y = 5;
            Assert.IsTrue(Helper.Add(x, y) == 15);
            y = 10;
            Assert.IsTrue(Helper.Add(x, y) == 20);

            Assert.AreEqual(Helper.Add(x, y), Helper.Add(x, y+1));
        }
    }
}
