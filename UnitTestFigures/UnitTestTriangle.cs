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
        public void TestSquareNegativeValues()
        {
            double s = 0;

            //Check for negative values
            //1
            s = _rightTriangle.Square(-2, 1, 2);
            Assert.AreEqual(0, s);
            //2
            s = _rightTriangle.Square(2, -1, 2);
            Assert.AreEqual(0, s);
            //3
            s = _rightTriangle.Square(2, 1, -2);
            Assert.AreEqual(0, s);
        }
        [TestMethod]
        public void TestSquareBadValues()
        {
            double s = 0;

            //Check for bad values
            //1
            s = _rightTriangle.Square(0, 1, 2);
            Assert.AreEqual(0, s);
            //2
            s = _rightTriangle.Square(2, 0, 2);
            Assert.AreEqual(0, s);
            //3
            s = _rightTriangle.Square(2, 1, 0);
            Assert.AreEqual(0, s);
            //4
            s = _rightTriangle.Square(0, 0, 0);
            Assert.AreEqual(0, s);
        }
        [TestMethod]
        public void TestSquareRelativeWrongValues()
        {
            double s = 0;

            //Check for relative wrong values
            //1
            s = _rightTriangle.Square(1, 2, 3);
            Assert.AreEqual(0, s);
            //2
            s = _rightTriangle.Square(1, 1, 2);
            Assert.AreEqual(0, s);
            //3
            s = _rightTriangle.Square(1.2, 5.986, 2.367);
            Assert.AreEqual(0, s);
        }
        [TestMethod]
        public void TestSquareRightTriangles()
        {
            double s = 0;

            //Check for not right triangles
            //1
            s = _rightTriangle.Square(50, 50, 50);
            Assert.AreEqual(0, s);
            //2
            s = _rightTriangle.Square(41, 10, 36);
            Assert.AreEqual(0, s);
            //3
            s = _rightTriangle.Square(214748, 1, 214748);
            Assert.AreEqual(0, s);
        }
        [TestMethod]
        public void TestSquareBoundaryValues()
        {
            double s = 0;

            //Check for good values. Compare double with elipson.
            //1
            s = _rightTriangle.Square(3, 4, 5);
            Assert.IsTrue(Math.Abs(s - 6) <= Double.Epsilon);
            //2
            s = _rightTriangle.Square(6, 8, 10);
            Assert.IsTrue(Math.Abs(s - 24) <= Double.Epsilon);
            //3
            s = _rightTriangle.Square(420, 44099, 44101);
            Assert.IsTrue(Math.Abs(s - 9260790) <= Double.Epsilon); 
            //4
            s = _rightTriangle.Square(4684659, 4684660, 6625109);
            Assert.IsTrue(Math.Abs(s - 10973017315470) <= Double.Epsilon);
        }
    }
}
