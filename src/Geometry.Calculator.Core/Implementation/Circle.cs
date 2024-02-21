using Geometry.Calculator.Core.Interface;

namespace Geometry.Calculator.Core.Implementation;

public class Circle : IGeometryCalculator
{
    private readonly double _radius;

    public Circle(double radius) => _radius = radius;

    public double Answer() => _radius <= 0 ? throw new ArgumentException("Проверьте входные данные") : Math.Round(Math.PI * Math.Pow(_radius,2),2,MidpointRounding.ToZero);
}