using NUnit.Framework;
using GeometryLib.Shape;

namespace GeometryLibraryTests
{
    public class ShapeTests
    {
        [Test]
        public void Circle_AreaCalculation_ShouldBeCorrect()
        {
            Circle circle = new Circle(5.0);
            double expectedArea = Math.PI * 25.0;
            double actualArea = circle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea, 1e-6);
        }

        [Test]
        public void Triangle_AreaCalculation_ShouldBeCorrect()
        {
            Triangle triangle = new Triangle(3.0, 4.0, 5.0);
            double expectedArea = 6.0;
            double actualArea = triangle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea, 1e-6);
        }

        [Test]
        public void Triangle_RightTriangleCheck_ShouldBeTrue()
        {
            Triangle rightTriangle = new Triangle(3.0, 4.0, 5.0);
            Assert.IsTrue(rightTriangle.IsRightTriangle());
        }

        [Test]
        public void Triangle_RightTriangleCheck_ShouldBeFalse()
        {
            Triangle nonRightTriangle = new Triangle(5.0, 7.0, 9.0);
            Assert.IsFalse(nonRightTriangle.IsRightTriangle());
        }
    }
}