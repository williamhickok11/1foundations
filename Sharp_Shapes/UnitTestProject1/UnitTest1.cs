using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sharp_Shapes;

namespace Sharp_ShapesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SquareTest()
        {
            Square square = new Square();
            Assert.IsInstanceOfType(square, typeof(Square));
        }

        [TestMethod]
        public void SquareAreaTest()
        {
            Square square3 = new Square();
            Square.height = 3.0;
            Square.width = 4.0;
            Assert.IsTrue(square3.equasion() == 12);
        }

        [TestMethod]
        public void RhombusTest()
        {
            Rhombus rhombus = new Rhombus();
            Assert.IsInstanceOfType(rhombus, typeof(Rhombus));
        }

        [TestMethod]
        public void RhombusAreaTest()
        {
            Rhombus square3 = new Rhombus();
            Rhombus.side = 3.0;
            Rhombus.altitude = 4.0;
            Assert.IsTrue(square3.areaEquasion() == 12);
        }
    }
}
