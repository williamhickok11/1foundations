using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simple_Calculator;

namespace CalaculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange 
            var calc = new Multiplication();

            //act
            var result = calc.multiplication(3, 3);

            //assert
            Assert.AreEqual(9, result);
        }
    }
}
