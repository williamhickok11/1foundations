using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician;

namespace MathMagicianTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SquareTest()
        {
            Methods method = new Methods();
            Assert.IsInstanceOfType(method, typeof(Methods));
        }

        [TestMethod]
        public void SquareAreaTest()
        {
            Methods newMethod = new Methods();

        }
    }
}
