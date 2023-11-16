using System;
using static System.Console;

class Program
{
    static void Main()
    {
        double circleRadius = 5;
        double triangleSideA = 3;
        double triangleSideB = 4;
        double triangleSideC = 5;

        try
        {
            double circleArea = GeometryLibrary.GeometryCalculator.CalculateCircleArea(circleRadius);
            WriteLine($"Area of the circle with radius {circleRadius}: {circleArea}");

            double triangleArea = GeometryLibrary.GeometryCalculator.CalculateTriangleArea(triangleSideA, triangleSideB, triangleSideC);
            WriteLine($"Area of the triangle with sides {triangleSideA}, {triangleSideB}, {triangleSideC}: {triangleArea}");
        }
        catch (ArgumentException ex)
        {
            WriteLine($"Error: {ex.Message}");
        }
    }
}
