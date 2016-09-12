using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician;

namespace MathMagicianTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void printIntegersTest()
        {
            Methods method = new Methods();
            Assert.IsInstanceOfType(method, typeof(Methods));
        }

        [TestMethod]
        public void printIntegersOutputTest()
        {
            Methods newMethod = new Methods();

        }

        [TestMethod]
        public void printFibonacciTest()
        {
            Methods method = new Methods();
            Assert.IsInstanceOfType(method, typeof(Methods));
        }

        [TestMethod]
        public void printFibonacciOutputTest()
        {
            Methods newMethod = new Methods();

        }

        [TestMethod]
        public void printPrimesTest()
        {
            Methods method = new Methods();
            Assert.IsInstanceOfType(method, typeof(Methods));
        }

        [TestMethod]
        public void printPrimesOutputTest()
        {
            Methods newMethod = new Methods();

        }
    }
}
