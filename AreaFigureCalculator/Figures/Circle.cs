namespace AreaFigureCalculator.Figures;

public class Circle : Figure
{
    /// <summary>
    /// Радиус круга
    /// </summary>
    private readonly double _radius;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="radius">Радиус круга</param>
    /// <exception cref="ArgumentException">Радиус не может равняться нулю или быть отрицательным</exception>
    public Circle(double radius)
    {
        if (radius == 0 || radius < 0)
            throw new ArgumentException();

        _radius = radius;
    }

    /// <summary>
    /// Вычисление площади круга
    /// </summary>
    /// <returns>Площадь круга</returns>
    public sealed override double CalculateSquare() => Math.PI * Math.Pow(_radius, 2);
}
