using ShapeLibrary;

namespace BaseTest
{
    public class Tests
    {
        [Test]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(14);
            Assert.That(circle.CalculateArea(), Is.EqualTo(615.75).Within(0.01));
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(6, 10, 12);
            Assert.That(triangle.CalculateArea(), Is.EqualTo(29.93).Within(0.01));
        }
    }
}