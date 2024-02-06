using ShapeLibrary;

Circle circle = new Circle(14);
Triangle triangle = new Triangle(6, 10, 12);

double result = circle.CalculateArea();
double triangleResult = triangle.CalculateArea();

Console.WriteLine(result);
Console.WriteLine(triangleResult);