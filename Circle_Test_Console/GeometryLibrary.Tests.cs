using NUnit.Framework;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    [TestFixture]
    public class GeometryCalculatorTests
    {
        [Test]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea(){
            // Arrange
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            // Act
            double actualArea = GeometryCalculator.CalculateCircleArea(radius);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Allowing for a small precision difference
        }

        [Test]
        public void CalculateCircleArea_NegativeRadius_ThrowsArgumentException(){
            // Arrange
            double radius = -2;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => GeometryCalculator.CalculateCircleArea(radius));
        }

        [Test]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea(){
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;

            // Act
            double actualArea = GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Allowing for a small precision difference
        }

        [Test]
        public void CalculateTriangleArea_InvalidSides_ThrowsArgumentException(){
            // Arrange
            double sideA = 0;
            double sideB = 4;
            double sideC = 5;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC));
        }

        [Test]
        public void IsRightTriangle_ValidRightTriangle_ReturnsTrue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            // Act
            bool isRightTriangle = GeometryCalculator.IsRightTriangle(sideA, sideB, sideC);

            // Assert
            Assert.IsTrue(isRightTriangle);
        }

        [Test]
        public void IsRightTriangle_ValidNonRightTriangle_ReturnsFalse()
        {
            // Arrange
            double sideA = 5;
            double sideB = 7;
            double sideC = 9;

            // Act
            bool isRightTriangle = GeometryCalculator.IsRightTriangle(sideA, sideB, sideC);

            // Assert
            Assert.IsFalse(isRightTriangle);
        }

        [Test]
        public void IsRightTriangle_InvalidSides_ThrowsArgumentException()
        {
            // Arrange
            double sideA = 0;
            double sideB = 4;
            double sideC = 5;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => GeometryCalculator.IsRightTriangle(sideA, sideB, sideC));
        }
    }
}
