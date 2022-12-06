using AreaFigureCalculator.Figures;
using Xunit;

namespace AreaFigureCalculatorTest
{
    /// <summary>
    /// Тестирование создания фигуры и вычисления её площади
    /// </summary>
    public class AreaFigureCalculatorTest
    {
        /// <summary>
        /// Тестирование создание круга и вычисление его площади с правильными значениями
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <param name="expected">Ожидаемая площадь круга</param>
        [Theory]
        [InlineData(2, 13)]
        [InlineData(3, 28)]
        [InlineData(5, 79)]
        public void CircleValidValuesTest(double radius, double expected)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            var result = Math.Round(circle.CalculateSquare(), 0);

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Тестирование создание круга с неправильными значениями
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CircleInvalidValuesTest(double radius)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        /// <summary>
        /// Тестирование создание треугольника и вычисление его площади с правильными значениями
        /// </summary>
        /// <param name="sideA">Длина стороны A</param>
        /// <param name="sideB">Длина стороны B</param>
        /// <param name="sideC">Длина стороны C</param>
        /// <param name="expected">Ожидаемая площадь треугольника</param>
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 5, 6, 12)]
        public void TriangleValidValuesTest(double sideA, double sideB, double sideC, double expected)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.CalculateSquare();

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Тестирование создание треугольника с неправильными значениями
        /// </summary>
        /// <param name="sideA">Длина стороны A</param>
        /// <param name="sideB">Длина стороны B</param>
        /// <param name="sideC">Длина стороны C</param>
        [Theory]
        [InlineData(0, 3, 4)]
        [InlineData(-2, 3, 4)]
        [InlineData(1, 1, 3)]
        public void TriangleInvalidValuesTest(double sideA, double sideB, double sideC)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        /// <summary>
        /// Тестирование треугольника на прямоугольность :)
        /// </summary>
        /// <param name="sideA">Длина стороны A</param>
        /// <param name="sideB">Длина стороны B</param>
        /// <param name="sideC">Длина стороны C</param>
        /// <param name="expected">Ожидаемая прямоугольность</param>
        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(2, 4, 4, false)]
        public void TriangleIsRightAngleTest(double sideA, double sideB, double sideC, bool expected)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.IsRightTriangle;

            // Assert
            Assert.Equal(expected, result);
        }
    
    }
}