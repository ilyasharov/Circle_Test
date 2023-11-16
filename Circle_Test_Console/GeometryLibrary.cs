using System;
using static System.Console;

namespace GeometryLibrary
{
    public class GeometryCalculator
    {
        // Calculate the area of a circle given its radius
        public static double CalculateCircleArea(double radius){
            if (radius < 0)
            {
                WriteLine("Radius cannot be negative.");
            }

            return Math.PI * Math.Pow(radius, 2);
        }

        // Calculate the area of a triangle given its three sides using Heron's formula
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC){
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                WriteLine("All sides of the triangle must be greater than zero.");
            }

            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        // Check if a triangle is a right triangle using the Pythagorean theorem
        public static bool IsRightTriangle(double sideA, double sideB, double sideC){
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                WriteLine("All sides of the triangle must be greater than zero.");
            }

            // Sort the sides to identify the longest side (sideC)
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
