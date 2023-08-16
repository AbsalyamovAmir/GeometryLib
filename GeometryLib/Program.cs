using System;
using GeometryLib.Shape;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5.0),
            new Triangle(3.0, 4.0, 5.0),
            new Triangle(5.0, 12.0, 13.0)
        };

        foreach (var shape in shapes)
        {
            double area = ShapeCalculator.CalculateArea(shape);
            Console.WriteLine($"Площадь фигуры: {area}");

            if (shape is Triangle triangle && triangle.IsRightTriangle())
            {
                Console.WriteLine("Это прямоугольный треугольник.");
            }
        }
    }
}