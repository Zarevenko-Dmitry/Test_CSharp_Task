using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_CSharp_Forms.Figures;

namespace UnitTestProject
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void RectangularTestMethod()
        {
            Triangle triangle;
            bool rectangular;

            triangle = new Triangle(3.0, 5.0, 4.0);
            rectangular = triangle.Rectangular();
            Assert.IsFalse(rectangular, "Is rectangular");

            triangle = new Triangle(3.0, 4.0, 4.0);
            rectangular = triangle.Rectangular();
            Assert.IsTrue(rectangular, "Is not rectangular");
        }

        [TestMethod]
        public void AreaTestMethod()
        {
            Triangle triangle;
            double area;

            triangle = new Triangle(3.0, 5.0, 4.0);
            area = triangle.Area();
            Assert.IsFalse(area == 6.0, "Incorrect area");
        }
    }
}
