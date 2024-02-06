namespace ShapeLibrary
{
    public class Circle : IShape
    {
        private readonly double _radious;

        public Circle(double radious)
        {
            _radious = radious;
        }

        public double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radious, 2), 2);
        }
    }
}
