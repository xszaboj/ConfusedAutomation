using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConfusedAutomation;

namespace ConfusedTests
{
    [TestClass]
    public class InitialTestCase
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new InitialTestClass();
            c.Go();
        }
    }
}
