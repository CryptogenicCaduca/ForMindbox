using System;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestFigures
{
    [TestClass]
    public class UnitTestTriangle
    {
        private Figures.RightTriangle _rightTriangle = new RightTriangle();
        //For more precise tests need more precise requirements
        /// <summary>
        /// Check for wrong values. Excpect bad result.
        /// </summary>
        [TestMethod]
        public void TestSquare()
        {
            double s = 0;

            //Check for negative values
            s = _rightTriangle.Square(-2, 1, 2);
            Assert.AreEqual(0, s);
            s = _rightTriangle.Square(2, -1, 2);
            Assert.AreEqual(0, s);
            s = _rightTriangle.Square(2, 1, -2);
            Assert.AreEqual(0, s);

            //Check for boundary values
            s = _rightTriangle.Square(0, 1, 2);
            Assert.AreEqual(0, s);
            s = _rightTriangle.Square(2, 0, 2);
            Assert.AreEqual(0, s);
            s = _rightTriangle.Square(2, 1, 0);
            Assert.AreEqual(0, s);
            s = _rightTriangle.Square(0, 0, 0);
            Assert.AreEqual(0, s);

            //Check for relative wrong values
            s = _rightTriangle.Square(1, 2, 3);
            Assert.AreEqual(0, s);
            s = _rightTriangle.Square(1, 1, 2);
            Assert.AreEqual(0, s);
            s = _rightTriangle.Square(1.2, 5.986, 2.367);
            Assert.AreEqual(0, s);

            //Check for not right triangles
            s = _rightTriangle.Square(50, 50, 50);
            Assert.AreEqual(0, s);
            s = _rightTriangle.Square(41, 10, 36);
            Assert.AreEqual(0, s);
            s = _rightTriangle.Square(214748, 1, 214748);
            Assert.AreEqual(0, s);

            //Check for good values. Compare double with elipson.
            s = _rightTriangle.Square(3, 4, 5);
            Assert.IsTrue(Math.Abs(s - 6) <= Double.Epsilon);
            s = _rightTriangle.Square(6, 8, 10);
            Assert.IsTrue(Math.Abs(s - 24) <= Double.Epsilon);
            s = _rightTriangle.Square(420, 44099, 44101);
            Assert.IsTrue(Math.Abs(s - 9260790) <= Double.Epsilon);
        }
    }
}
