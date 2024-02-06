namespace ShapeLibrary
{
    public class Triangle : IShape
    {
        private readonly double _a, _b, _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double CalculateArea()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Round(Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c)), 2);
        }

        public bool IsRightAngleTriangle()
        {
            return Math.Pow(_a, 2) == Math.Pow(_b, 2) + Math.Pow(_c, 2) ||
                Math.Pow(_b, 2) == Math.Pow(_a, 2) + Math.Pow(_c, 2) ||
                Math.Pow(_c, 2) == Math.Pow(_a, 2) + Math.Pow(_c, 2);
        }
    }
}
